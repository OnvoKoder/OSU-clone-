using OSU_clone.Properties;

namespace OSU_clone
{
    public partial class mainForm : Form
    {
        public Bitmap HandlerTexture = Resources.ring,
        TargetTexture = Resources.ring_target;
        private Point targetPosition = new Point(200,200);
        private Point direction=Point.Empty;
        private int score=0;
        public mainForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            UpdateStyles();
        }
        private void renderRing_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void moveRing_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            moveRing.Interval = rnd.Next(25, 500);
            direction.X = rnd.Next(-1, 2);
            direction.Y = rnd.Next(-1, 2);
        }

        private void mainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            var localPosition=this.PointToClient(Cursor.Position);
            targetPosition.X += direction.X;
            targetPosition.Y += direction.Y;
            if(targetPosition.X < 0 || targetPosition.X>500)
                direction.X *=-1;
            if(targetPosition.Y < 0 || targetPosition.Y>500)
                targetPosition.Y *=-1;
            Point between = new Point(localPosition.X-targetPosition.X,localPosition.Y-targetPosition.Y);
            float distance = (float)Math.Sqrt((between.X * between.X) + (between.Y * between.Y));
            if (distance < 5)
                GetScore(1);
            var handlerRectangle = new Rectangle(localPosition.X - 50, localPosition.Y - 50, 100, 100);
            var targetRectangle=new Rectangle(targetPosition.X - 50, targetPosition.Y - 50, 90, 90);
            graphics.DrawImage(HandlerTexture,handlerRectangle);
            graphics.DrawImage(TargetTexture,targetRectangle);
        }
        //Logic
        private void GetScore(int _score)
        {
            score += _score;
            scoreText.Text = "—чет: " + score.ToString();
        }
    }
}