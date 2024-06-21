namespace cs0614
{
    public partial class Form1 : Form
    {
        static int ChrMax => 100;

        static Random random = new Random();
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        Label[] labels = new Label[ChrMax];//ラベル100個分の空きを確保

        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < ChrMax; i++)
            {
                labels[i] = new Label();//管理する領域を生成
                labels[i].AutoSize = true;
                labels[i].Text = "♦";
                labels[i].Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular);
                Controls.Add(labels[i]);

                labels[i].Left = random.Next(ClientSize.Width - labels[i].Width);
                labels[i].Top = random.Next(ClientSize.Height - labels[i].Height);


                vx[i] = random.Next(-10, 11);
                vy[i] = random.Next(-10, 11);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            vx[0] = vx[0] * 2;
            vy[0] = vy[0] * 2;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            vx[1] = vx[1] * 2;
            vy[1] = vy[1] * 2;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            vx[2] = vx[2] * 2;
            vy[2] = vy[2] * 2;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ChrMax; i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

                if (labels[i].Left < 0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                else if (labels[i].Left > (ClientSize.Width - labels[i].Width))
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                else if (labels[i].Top < 0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                else if (labels[i].Top > (ClientSize.Height - labels[i].Height))
                {
                    vy[i] = -Math.Abs(vy[i]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show($"{i}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                if (i == 5)
                {
                    break;
                }
                MessageBox.Show(i.ToString());
            }

            MessageBox.Show($"after{i}");
        }
    }
}