using Ergasia3.Source.Backend;
using System.Xml;

namespace Ergasia3.Source.Frontend.DJockeyHall
{
	public partial class DJHall : BaseForm
	{
		private const string PlaySymbol = "|>";
		private const string PauseSymbol = "||";
		private const int DefaultBPM = 120;

		private readonly List<Song> songs = [];

		#region Constructor definition
		public DJHall()
		{
			InitializeComponent();
			readSongsFromXML();

			foreach (Song s in songs)
			{
				ListViewItem newItem = songsListView.Items.Add(s.Name);
				newItem.SubItems.Add(s.Artist);
				newItem.SubItems.Add(s.Category);
				newItem.SubItems.Add(s.Duration);
			}
			pauseButton.Text = PlaySymbol;
			mediaPlayer.Visible = false;
			mediaPlayer.settings.volume = Globals.Volume;
			playingSongLbl.Text = string.Empty;
		}
		#endregion

		#region Function definition

		private void readSongsFromXML()
		{
			XmlDocument doc = new();
			doc.Load("Data/Songs.xml");

			XmlNode? rootNode = doc.SelectSingleNode("songs");
			if( rootNode == null )
				throw new XmlException("Root node != songs");

			foreach (XmlNode song in rootNode.ChildNodes)
			{
				if (song.Attributes == null || song.Attributes.Count != 5)
					throw new XmlException("Incorrect amount of attributes for song!");

				if (song.Attributes["title"] == null ||
					song.Attributes["artist"] == null ||
					song.Attributes["category"] == null ||
					song.Attributes["duration"] == null ||
					song.Attributes["songPath"] == null)
					throw new XmlException("Incorrect attributes for song!");

				songs.Add(new Song(
					song.Attributes["title"].Value,
					song.Attributes["artist"].Value,
					song.Attributes["category"].Value,
					song.Attributes["duration"].Value,
					song.Attributes["songPath"].Value
				));
			}
		}

		private void DigitalDJForm_Shown(object sender, EventArgs e)
		{
			BPM_scrollbar.Value = DefaultBPM;
		}

		private void DigitalDJ_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.OpenForms[0]?.Show();
		}

		private void BPM_scrollbar_ValueChanged(object sender, EventArgs e)
		{
			BPM_textLbl.Text = BPM_scrollbar.Value.ToString();
		}

		private void songsListView_SelIndexChanged(object sender, EventArgs e)
		{
			if (songsListView.SelectedItems.Count == 0)
				return;

			int index = songsListView.SelectedItems[0].Index;
			mediaPlayer.URL = songs[index].SongPath;
			pauseButton.Text = PauseSymbol;
			playingSongLbl.Text = $"{songs[index].Artist} | {songs[index].Name} | {songs[index].Category}";
		}

		private void pauseButton_Click(object sender, EventArgs e)
		{
			if (pauseButton.Text.Equals(PauseSymbol))
			{
				pauseButton.Text = PlaySymbol;
				mediaPlayer.Ctlcontrols.pause();
			}
			else
			{
				pauseButton.Text = PauseSymbol;
				mediaPlayer.Ctlcontrols.play();
			}
		}

		private void prevSongBtn_Click(object sender, EventArgs e)
		{
			if (songsListView.Items.Count == 0 || songsListView.SelectedItems.Count == 0)
				return;

			int curIndex = songsListView.SelectedItems[0].Index;
			songsListView.SelectedItems.Clear();
			if (curIndex > 0)
				songsListView.Items[curIndex - 1].Selected = true;
			else
				songsListView.Items[songsListView.Items.Count - 1].Selected = true;
			songsListView.Select();
		}

		private void nextSongBtn_Click(object sender, EventArgs e)
		{
			if (songsListView.Items.Count == 0 || songsListView.SelectedItems.Count == 0)
				return;

			int curIndex = songsListView.SelectedItems[0].Index;
			songsListView.SelectedItems.Clear();
			if (curIndex < songsListView.Items.Count - 1)
				songsListView.Items[curIndex + 1].Selected = true;
			else
				songsListView.Items[0].Selected = true;
			songsListView.Select();
		}
		#endregion

		private readonly struct Song(string name, string artist,
			string category, string duration, string songpath)
		{
			public string Name { get; } = name;
			public string Artist { get; } = artist;
			public string Category { get; } = category;
			public string Duration { get; } = duration;
			public string SongPath { get; } = songpath;
		}
	}
}
