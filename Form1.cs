namespace MusicPlayerapp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        //Create Global Variables of String Type array to save the titles or name of the tracks and path of the track. learn more on the string type array
        // paths will hold the paths of the selected music and files will store the track
        string[] paths, files;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // code to close our app
            this.Close();
        }

        private void btnselectsongs_Click(object sender, EventArgs e)
        {
            // creating an event on the select button
            OpenFileDialog ofd = new OpenFileDialog();
            // code to select multiple file 
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;// save the names of the track in files array
                paths = ofd.FileNames; // save the paths of the tracks in path array
                // Display the music titles in listbox 
                for (int i = 0; i < files.Length; i++)
                {
                    listboxsongs.Items.Add(files[i]); // display songs in listbox
                }
            }
        }

        private void listboxsongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // write a code to play music 
            axWindowsMediaPlayermusic.URL=paths[listboxsongs.SelectedIndex];
        }
    }
}
