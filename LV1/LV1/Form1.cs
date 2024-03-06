namespace LV1
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer t;
        private StreamReader r;
        public Form1()
        {
            InitializeComponent();
            //Kreiranje timer-a s periodom od 1000 ms
            t = new System.Timers.Timer(1000);
           
            r = new StreamReader("D:\\RSSV\\LV1\\LV1\\values.txt");

            //Dodavanje događaja timer-u; izvršava se periodno
            t.Elapsed += new System.Timers.ElapsedEventHandler(vrijeme);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            r.Close();
        }

        private void vrijeme(object s, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                lb1_vrijeme.Text = DateTime.Now.ToLongTimeString();
                readValueFromFile();
                ringAlarm();
            });
        }

        private void btn_start_stop_Click(object sender, EventArgs e)
        {
            if (t.Enabled == false)
            {
                t.Start();
                btn_start_stop.Text = "Zaustavi";
            }
            else
            {
                t.Stop();
                btn_start_stop.Text = "Pokreni";
            }
        }

        private void readValueFromFile()
        {
            Invoke((MethodInvoker)delegate
            {
                string line;
                if ((line = r.ReadLine()) != null)
                {
                    lbReadItems.Items.Add(line);
                    lbReadItems.Refresh();

                    if(IsCriticalValue(line))
                    {
                        lbWarning.Text = "Value read from file is greater than critical value!";
                    }
                    else
                    {
                        lbWarning.Text = "Nothing to report!";
                    }
                }  
            });
        }

        private bool IsCriticalValue(String readValue)
        {
            if(textBoxInput.Text == "")
            {
                return false;
            }
            else
            {
                int criticalValue = Int32.Parse(textBoxInput.Text);
                return criticalValue < Int32.Parse(readValue);
            }
        }

        private void ringAlarm()
        {
            if(textBoxHour.Text != "" && textBoxMinute.Text != "")
            {
                int hours = Int32.Parse(textBoxHour.Text);
                int minutes = Int32.Parse(textBoxMinute.Text);

                if(DateTime.Now.Hour.Equals(hours) && DateTime.Now.Minute.Equals(minutes))
                {
                    Console.Beep();
                }
            }          
        }
    }
}