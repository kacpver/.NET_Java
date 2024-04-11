namespace Przetwarzanie_obrazów
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        
        private Bitmap? img;
        private static Mutex mutex = new Mutex();
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                img = new Bitmap(file);
                pictureBox1.Image = img;
            }
        }

        public void thresholding(Bitmap loadImage)
        {
            Bitmap originalImage = (Bitmap)loadImage.Clone();
            Bitmap thrImage = new Bitmap(originalImage.Width, originalImage.Height);
            
            int threshold = 125;
            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int j = 0; j < originalImage.Height; j++)
                {
                    Color pixelColor = originalImage.GetPixel(i, j);
                    int grayscaleValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    Color thresholdColor = (grayscaleValue >= threshold)? Color.White : Color.Black;
                    thrImage.SetPixel(i, j, thresholdColor);
                }
            }
            pictureBox3.Image = thrImage;
        }

        public void negativ(Bitmap loadImage)
        {
            Bitmap originalImage = (Bitmap)loadImage.Clone();
            Bitmap negImage = new Bitmap(originalImage.Width, originalImage.Height);
           
            for (int i = 0; i < negImage.Width; i++)
            {
                for (int j = 0; j < negImage.Height; j++)
                {
                    Color pixelColor = originalImage.GetPixel(i, j);
                    int r = 255 - pixelColor.R;
                    int g = 255 - pixelColor.G;
                    int b = 255 - pixelColor.B;
                    Color negColor = Color.FromArgb(r, g, b);
                    negImage.SetPixel(i, j, negColor);
                }
            }
            pictureBox2.Image = negImage;
        }

        public void gray(Bitmap loadImage)
        {
            Bitmap originalImage = (Bitmap)loadImage.Clone();
            Bitmap grayImage = new Bitmap(originalImage.Width, originalImage.Height); 
           
            for (int i = 0; i < grayImage.Width; i++)
            {
                for (int j = 0; j < grayImage.Height; j++)
                {

                    Color pixelColor = originalImage.GetPixel(i, j);
                    int grayscaleValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    grayImage.SetPixel(i, j, Color.FromArgb(grayscaleValue,grayscaleValue,grayscaleValue));
                }
            }
            pictureBox5.Image = grayImage;
        }
        
        public void mirror(Bitmap loadImage)
        {
            Bitmap originalImage = (Bitmap)loadImage.Clone();
            Bitmap mirrorImage = new Bitmap(originalImage.Width, originalImage.Height); 
            
            for (int i = 0; i < mirrorImage.Width; i++)
            {
                for (int j = 0; j < mirrorImage.Height; j++)
                {
                    int newI = originalImage.Width - 1 - i;
                    mirrorImage.SetPixel(newI, j, originalImage.GetPixel(i, j));
                }
            }
            pictureBox4.Image = mirrorImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (img == null)
            {
                MessageBox.Show("Load image before processing");
                return;
            }
            Thread[] threads =
            [
                new Thread(() => thresholding(img)),
                new Thread(() => negativ(img)),
                new Thread(() => gray(img)),
                new Thread(() => mirror(img)),
            ];
            foreach (var thread in threads) thread.Start();
            foreach (var thread in threads) thread.Join();
            //thresholding(img);
            //negativ(img);
            //gray(img);
            //mirror(img);

        }
    }
}
