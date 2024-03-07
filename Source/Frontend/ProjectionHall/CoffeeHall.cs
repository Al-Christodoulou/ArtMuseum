using Ergasia3.Source.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ergasia3.Source.Frontend.CinemaHall
{
	public partial class CoffeeHall : BaseForm
	{

		private const uint ItemLimit = 3;

		private ItemSelection itemSelection = ItemSelection.Foods;
		private Item[] foods = new Item[ ItemLimit ];
		private Item[] drinks = new Item[ ItemLimit ];
		private readonly uint[] foodAmount = new uint[ ItemLimit ];
		private readonly uint[] drinkAmount = new uint[ ItemLimit ];
		private Item[] selectedItems = [];
		private uint[] pickedFoods = new uint[ ItemLimit ];
		private uint[] pickedDrinks = new uint[ ItemLimit ];

		// c_ meaning control, to avoid confusion
		private PictureBox[] c_itemImages;
		private Label[] c_itemNames, c_itemsLeft, c_itemsPrice, c_itemsPicked;
		private Button[][] c_buttons;

		#region Constructor definition
		public CoffeeHall()
		{
			InitializeComponent();
			this.initializeElements();
		}
		#endregion

		#region Function definition
		private void CoffeeHall_FormClosed( object sender, FormClosedEventArgs e )
		{
			Application.OpenForms[ 1 ]?.Show();
		}

		private void initializeElements()
		{
			this.readCoffeeHallItems();

			this.c_itemImages = [ this.Food1Pbx, this.Food2Pbx, this.Food3Pbx ];
			this.c_itemNames = [ this.Food1Name, this.Food2Name, this.Food3Name ];
			this.c_itemsLeft = [ this.Left1Lbl, this.Left2Lbl, this.Left3Lbl ];
			this.c_itemsPrice = [ this.Price1Lbl, this.Price2Lbl, this.Price3Lbl ];
			this.c_itemsPicked = [ this.Picked1Lbl, this.Picked2Lbl, this.Picked3Lbl ];

			this.pickedFoods = [ 0, 0, 0 ];
			this.pickedDrinks = [ 0, 0, 0 ];

			this.c_buttons = [
				[ Decrease1Btn, Increase1Btn ],
				[ Decrease2Btn, Increase2Btn ],
				[ Decrease3Btn, Increase3Btn ]
			];

			Random random = new();
			for( int k = 0; k < ItemLimit; k++ )
			{
				this.foodAmount[ k ] = ( uint )(33 * random.NextDouble());
				this.drinkAmount[ k ] = ( uint )(42 * random.NextDouble());
			}

			// this needs to be done first since FoodRbtn.Checked = true calls
			// FoodRbtn_CheckedChanged(), which later accesses selectedItems
			this.selectedItems = foods;
			this.FoodRbtn.Checked = true;
			this.DrinkRbtn.Checked = false;
			this.updateFormItems();
		}

		private void readCoffeeHallItems()
		{
			XmlDocument document = new();
			document.Load( "Data/CoffeeHall.xml" );

			XmlNode? rootNode = document.SelectSingleNode( "coffeehall" );
			if( rootNode == null )
			{
				var message = "Couldn't find root node!";
				throw new Exception( message );
			}

			XmlNode? foodNode = rootNode.SelectSingleNode( "foods" );
			XmlNode? drinkNode = rootNode.SelectSingleNode( "drinks" );

			if( foodNode == null || drinkNode == null )
			{
				var message = "foods or drinks node doesn't exist!";
				throw new Exception( message );
			}

			this.foods = this.grabItemsFrom( foodNode );
			this.drinks = this.grabItemsFrom( drinkNode );
		}

		private Item[] grabItemsFrom( XmlNode node )
		{
			if( node.ChildNodes.Count != ItemLimit )
			{
				var message = $"{node.Name} node must have {ItemLimit} children nodes!";
				throw new Exception( message );
			}

			var returnedItems = new Item[ ItemLimit ];
			for( int i = 0; i < node.ChildNodes.Count; i++ )
			{
				XmlNode? itemNode = node.ChildNodes[ i ];
				if( itemNode.Attributes == null || itemNode.Attributes.Count != ItemLimit )
				{
					var message = "Incorrect amount of attributes in item node!";
					throw new Exception( message );
				}

				if( itemNode.Attributes[ "name" ] == null ||
					itemNode.Attributes[ "price" ] == null ||
					itemNode.Attributes[ "imagePath" ] == null )
				{
					var message = "Incorrect attributes in item node!";
					throw new Exception( message );
				}

				var name = itemNode.Attributes[ "name" ]?.Value;
				var price = float.Parse( itemNode.Attributes[ "price" ]?.Value );
				var imagePath = itemNode.Attributes[ "imagePath" ]?.Value;
				returnedItems[ i ] = new Item( name, price, imagePath );
			}

			return returnedItems;
		}

		private void FoodRbtn_CheckedChanged( object sender, EventArgs e )
		{
			this.itemSelection = ItemSelection.Foods;
			updateFormItems();
		}

		private void DrinkRbtn_CheckedChanged( object sender, EventArgs e )
		{
			this.itemSelection = ItemSelection.Drinks;
			updateFormItems();
		}

		private void updateItems()
		{
			for( int item = 0; item < this.c_itemImages.Length; item++ )
			{
				this.c_itemImages[ item ].Load( this.selectedItems[ item ].ImagePath );
				this.c_itemNames[ item ].Text = this.selectedItems[ item ].Name;
				this.c_itemsPrice[ item ].Text = $"{this.selectedItems[ item ].Price:f2}";
			}
			enableAllItems();
		}

		private void updateAmountQuantity()
		{
			var itemAmounts = this.itemSelection == ItemSelection.Foods ?
				this.foodAmount : this.drinkAmount;
			var pickedItems = this.itemSelection == ItemSelection.Foods ?
				this.pickedFoods : this.pickedDrinks;

			for( int i = 0; i < this.c_itemImages.Length; i++ )
			{
				this.c_itemsLeft[ i ].Text = itemAmounts[ i ].ToString();
				this.c_itemsPicked[ i ].Text = pickedItems[ i ].ToString();
			}
		}

		private void clearPickedQuantities()
		{
			var pickedItems = itemSelection == ItemSelection.Foods ?
				pickedFoods : pickedDrinks;

			for( int i = 0; i < pickedItems.Length; i++ )
			{
				pickedItems[ i ] = 0;
				this.c_itemsPicked[ i ].Text = "0";
			}
		}

		private void updateFormItems()
		{
			this.selectedItems = this.itemSelection switch
			{
				ItemSelection.Foods => this.foods,
				ItemSelection.Drinks => this.drinks,
				_ => this.foods,
			};

			this.updateItems();
			this.updateAmountQuantity();
			this.disableOutOfStockItems();
			this.updateTotalPrice();
		}

		private void BuyBtn_Click( object sender, EventArgs e )
		{
			if( pickedDrinks.All( amt => amt == 0 ) && pickedFoods.All( amt => amt == 0 ) )
			{
				AppMessage.showMessageBox(
					"Please add an item for purchase!",
					MessageBoxIcon.Warning
				);
				return;
			}

			// TODO: perhaps make the foods/drinks, foodAmount/drinkAmount etc
			// 2D arrays to make access easier than doing this?
			var selectedFoods = itemSelection == ItemSelection.Foods ?
								foods : drinks;
			var selectedAmountType = itemSelection == ItemSelection.Foods ?
									foodAmount : drinkAmount;
			var selectedPickedType = itemSelection == ItemSelection.Foods ?
									pickedFoods : pickedDrinks;

			// we've made sure from the checks in the GUI that the client will
			// not try and buy more items than those that are available
			for( int i = 0; i < ItemLimit; i++ )
				selectedAmountType[ i ] -= selectedPickedType[ i ];

			AppMessage.showMessageBox( "Purchase successful!", MessageBoxIcon.Information );
			this.updateAmountQuantity();
			this.disableOutOfStockItems();
			this.clearPickedQuantities();
			this.updateTotalPrice();
		}

		private void updateTotalPrice()
		{
			var pickedItemsAmount = itemSelection == ItemSelection.Foods ?
				pickedFoods : pickedDrinks;

			TotalPrice.Text = (
				selectedItems[ 0 ].Price * pickedItemsAmount[ 0 ] +
				selectedItems[ 1 ].Price * pickedItemsAmount[ 1 ] +
				selectedItems[ 2 ].Price * pickedItemsAmount[ 2 ]
			).ToString( "f2" );
		}

		private void disableOutOfStockItems()
		{
			var selectedItemAmounts = this.itemSelection == ItemSelection.Foods ?
									this.foodAmount : this.drinkAmount;

			static void makePanelsGray( params Button[] btns )
			{
				foreach( Button btn in btns )
				{
					btn.Enabled = false;
					btn.BackColor = Color.Gray;
				}
			}

			for( int i = 0; i < selectedItemAmounts.Length; i++ )
				if( selectedItemAmounts[ i ] == 0 )
					makePanelsGray( this.c_buttons[ i ][ 0 ], this.c_buttons[ i ][ 1 ] );
		}

		private void enableAllItems()
		{
			for( int i = 0; i < this.c_buttons.Length; i++ )
			{
				for( int j = 0; j < this.c_buttons[ 0 ].Length; j++ )
				{
					this.c_buttons[ i ][ j ].Enabled = true;
					this.c_buttons[ i ][ j ].BackColor =
						Palette.ColorMap[ Globals.SelectedPaletteIndex ].Color1;
				}
			}
		}

		private void ChangeItemQuantity_Click( object sender, EventArgs e )
		{
			// this should not crash
			Button btn = ( Button )sender;

			int getIndex()
			{
				if( btn.Name.Contains( '1' ) )
					return 0;
				else if( btn.Name.Contains( '2' ) )
					return 1;
				else if( btn.Name.Contains( '3' ) )
					return 2;
				else
					throw new Exception( "Button has incorrect name structure!" );
			}

			var pickedItems = itemSelection == ItemSelection.Foods ?
				pickedFoods : pickedDrinks;
			var itemAmounts = itemSelection == ItemSelection.Foods ?
				foodAmount : drinkAmount;

			int index = getIndex();
			if( btn.Text.Equals( "-" ) )
			{
				if( pickedItems[ index ] > 0 )
					--pickedItems[ index ];
			}
			else if( btn.Text.Equals( "+" ) )
			{
				if( pickedItems[ index ] < itemAmounts[ index ] )
					++pickedItems[ index ];
			}
			else
				throw new Exception( "Button has incorrect text applied to it!" );

			updateAmountQuantity();
			updateTotalPrice();
		}
		#endregion

		private readonly struct Item( string name, float price, string imagepath )
		{
			internal string Name { get; } = name;
			internal float Price { get; } = price;
			internal string ImagePath { get; } = imagepath;
		};

		private enum ItemSelection
		{
			Foods,
			Drinks,
			MAX_ITEMSELECTIONS
		}
	}
}