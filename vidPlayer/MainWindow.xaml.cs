using System;
using System.IO;
using System.Windows;
using System.Windows.Media;
using Microsoft.Win32;
using System.Windows.Threading;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace vidPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Double> Times = new List<Double>(); // list to store the times
        public bool play = true;
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(.01);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            if (mePlayer.Source != null)
            {
                if (mePlayer.NaturalDuration.HasTimeSpan)
                {

                    if ( TimesCombo.HasItems)
                    {
                      // for each item in the Times array ( combo box, but each value is individual not paired)
                      // if the meplayer current time is == to timecombo
                      for ( int i = 0; i < Times.Count; i+=2)
                        {
                            // even indexes are start of cut sequence, odd are where it should stop
                            if ( Convert.ToDouble(mePlayer.Position.TotalSeconds) >= Times[i] && Convert.ToDouble(mePlayer.Position.TotalSeconds) <= Times[i+1])
                            {
                                mePlayer.Position = TimeSpan.FromSeconds(Times[i + 1]);
                            }
                        }
                        

                    }
                    lblStatus.Content = String.Format("{0} / {1}", mePlayer.Position.ToString(@"mm\:ss"), mePlayer.NaturalDuration.TimeSpan.ToString(@"mm\:ss"));
                }
            }
            else
                lblStatus.Content = "No file selected...";
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            if ( play == true)
            {
                PlayPause.Source = new BitmapImage(new Uri(@"/Pause.png", UriKind.RelativeOrAbsolute));
                play = false;
                mePlayer.Play();
            }
            else
            {
                PlayPause.Source = new BitmapImage(new Uri(@"/Play.png", UriKind.RelativeOrAbsolute));
                play = true;
                mePlayer.Pause();

            }

        }


        private void UploadTimeStamps(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true) // this returns true if the user clicks on the ok in the dialog box
            {

                using (var reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
 
                    while ( (line = reader.ReadLine() ) != null)
                    {
                        char[] delimiters = { ' ', '\t' };
                        string[] words = line.Split(delimiters);
                        TimesCombo.Items.Add(words[0] + " - " + words[1]);
                        Times.Add(Convert.ToDouble(words[0]));
                        Times.Add(Convert.ToDouble(words[1]));
             
                    }
                }

                

            }
        }
        private void UploadVideo(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Media files (*.mp3;*.mpg;*.mpeg;*.mp4;*.mov)|*.mp3;*.mpg;*.mpeg;*.mp4;*.mov|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true) // this returns true if the user clicks on the ok in the dialog box
            {

                mePlayer.Source = mePlayer.Source = new Uri(openFileDialog.FileName);
                
                mePlayer.Pause();

            }
        } // end of upload video method

        private void skip_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToDouble(mePlayer.Position.TotalSeconds) >= 10.0 )
            {
                mePlayer.Position = TimeSpan.FromSeconds(Convert.ToDouble(mePlayer.Position.TotalSeconds) - 10.0);
            }

        }
    }//end of public partial class
} // end of namespace
