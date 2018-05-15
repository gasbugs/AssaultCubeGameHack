using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssaltCubeGameHack
{

    public partial class OverlayForm : Form
    {
        Graphics g;
        Pen myPen = new Pen(Color.Red);
        IntPtr hAssualtCube;
        PosEnemy[] posEnemy = new PosEnemy[30];

        public const string WINDOWNAME = "AssaultCube";
        RECT rect;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        public struct PosEnemy
        {
            public float x;
            public float y;
            public float size;
        }


        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);
        [DllImport("user32")]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);


        public OverlayForm()
        {
            InitializeComponent();
        }

        private void OverlayForm_Load(object sender, EventArgs e)
        {
            /* 창에 대한 속성 조절 */
            this.BackColor = Color.Wheat; // 배경 색 없음
            this.TransparencyKey = Color.Wheat; // 투명한 영역에다가 이미지 업데이트
            this.TopMost = true; // 가장 상단 노출
            this.FormBorderStyle = FormBorderStyle.None; // 창의 틀이 완전히 삭제

            int presnetStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, presnetStyle | 0x80000 | 0x20); // 마우스 이벤트 뒤로 전달 속성 추가

            /* 창에 대한 위치와 크기 조절 */
            hAssualtCube = FindWindow(null, WINDOWNAME); // AssaultCube 창을 찾아 핸들을 저장 
            GetWindowRect(hAssualtCube, out rect);

            // 창 사이즈
            int height = rect.Bottom - rect.Top;
            int width = rect.Right - rect.Left;
            this.Size = new Size(width, height);

            // 창 위치
            this.Top = rect.Top;
            this.Left = rect.Left;


            timer1.Enabled = true;
        }

        

        // 모든 창이 초기화된 뒤에 사용되도록 로드되는 마지막에 타이머 온
        private void timer1_Tick(object sender, EventArgs e)
        {
            GetWindowRect(hAssualtCube, out rect);

            // 창 사이즈
            int height = rect.Bottom - rect.Top;
            int width = rect.Right - rect.Left;
            this.Size = new Size(width, height);

            // 창 위치
            this.Top = rect.Top;
            this.Left = rect.Left;
        }

        private void OverlayForm_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            //g.DrawRectangle(myPen, 100, 100, 150, 150);

            for (int i = 0; i < 10; i++)
            {
                if(posEnemy[i].x != -1234)
                {
                    g.DrawRectangle(myPen, posEnemy[i].x - posEnemy[i].size/2, posEnemy[i].y- posEnemy[i].size/2, posEnemy[i].size, posEnemy[i].size*2);
                    //g.DrawRectangle(myPen, (rect.Right - rect.Left)/ 2, (rect.Bottom - rect.Top) / 2, 10,10);
                }
            }
        }

        internal void hackWall(PlayerData mainPlayer, PlayerData[] enemyPlayer)
        {
            for (int i = 0; i < 10; i++) // 10명의 플레이어를 검사
            {
                float x_angle_pos = mainPlayer.x_angle - Double2Float(enemyPlayer[i].head_x_angle);
                float y_angle_pos = mainPlayer.y_angle - Double2Float(enemyPlayer[i].head_y_angle);

                // 실제 각도와 다르게 측정되는 경우, 실제 각도로 보정
                // 예: 359 - 1 = 358 --> -2도
                // 예: 1 - 359 = -358 --> 2도
                if (360 - 45 <= Math.Abs(x_angle_pos) && Math.Abs(x_angle_pos) <= 360)
                {
                    if (x_angle_pos > 0) // 360 - 0
                        x_angle_pos -= 360; // 예: 359 - 1 = 358 --> -2도
                    else
                        x_angle_pos += 360; // 예: 1 - 359 = -358 --> 2도
                }

                // 내 시야에 있는 것 체크
                if ((Math.Abs(x_angle_pos) <= 45) && enemyPlayer[i].health > 0) //길이가 총 90도
                {
                    float x_corr = (rect.Right - rect.Left) / 90 * x_angle_pos;
                    float y_corr = (rect.Bottom - rect.Top) / 60 * y_angle_pos;

                    posEnemy[i].x = ((rect.Right - rect.Left) / 2) - x_corr;
                    posEnemy[i].y = ((rect.Bottom - rect.Top) / 2) + y_corr;
                    posEnemy[i].size = Double2Float(1800 / enemyPlayer[i].distance);
                }

                else
                {
                    posEnemy[i].x = -1234;
                    posEnemy[i].y = -1234;
                }
            }
            this.Invalidate(); // 페인트 초기화
        }

        private float Double2Float(double input)
        {
            float result = (float)input;
            if (float.IsPositiveInfinity(result))
            {
                result = float.MaxValue;
            }
            else if (float.IsNegativeInfinity(result))
            {
                result = float.MinValue;
            }
            return result;
        }
    }
}
