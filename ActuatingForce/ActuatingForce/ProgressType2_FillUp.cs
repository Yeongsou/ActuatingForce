using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActuatingForce
{
    public partial class ProgressType2_FillUp : UserControl
    {
        public ProgressType2_FillUp()
        {
            InitializeComponent();

            Size = new Size(100, 100);
            Font = new Font("맑은 고딕", 20);
            MinimumSize = new Size(80, 80);
            DoubleBuffered = true;
        }
        #region Enums

        public enum _ProgressShape
        {
            Flat,
            Round
        }

        public enum _AngleRangeStyle
        { 
            Auto,
            Manual
        }


        public enum _DecimalPlaces
        {
            Non,
            첫번째,
            두번째,
            세번째
        }


        #endregion

        #region Variables

        private int _startAngle = -230;
        private int _angleRange = 280;
        private int _DivideVal = 1;
        private int blankVal = 2;

        private Double _Value;
        private Double _Maximum = 100;
        private Double _Minimum = 0;
        private Color _ProgressColorBase = Color.Gray;
        private _ProgressShape ProgressShapeVal;
        private _AngleRangeStyle AngleRangeVal;
        private _DecimalPlaces DecimalPlacesVal;

        private Font _minmaxFont = new Font("굴림", 10);
        private Color _minmaxForeColor = Color.DarkGray;

        private float _specUp = 0.0f;
        private float _specLow = 0.0f;
        private Color _specColorIn = Color.PaleGreen;
        private Color _specColorOut = Color.Pink;


        #endregion

        #region Custom Properties

        public float SpecUp
        {
            get { return _specUp; }
            set
            {
                _specUp = value;
                Invalidate();
            }
        }
        public float SpecLow
        {
            get { return _specLow; }
            set
            {
                _specLow = value;
                Invalidate();
            }
        }
        public Color SpecColor_IN
        {
            get { return _specColorIn; }
            set
            {
                _specColorIn = value;
                Invalidate();
            }
        }
        public Color SpecColor_OUT
        {
            get { return _specColorOut; }
            set
            {
                _specColorOut = value;
                Invalidate();
            }
        }

        public Font MinMaxFont
        {
            get => this._minmaxFont;
            set
            {
                this._minmaxFont = value;
                Invalidate();
            }
        }
        public Color MinMaxForeColor
        {
            get { return _minmaxForeColor; }
            set
            {
                _minmaxForeColor = value;
                Invalidate();
            }
        }

        public int Blank
        {
            get { return blankVal; }
            set
            {
                blankVal = value;
                Invalidate();
            }
        } 
        public int AngleStart
        {
            get { return _startAngle; }
            set
            {
                _startAngle = value;
                Invalidate();
            }
        }
        public int AngleRange
        {
            get { return _angleRange; }
            set
            {
                _angleRange = value;
                Invalidate();
            }
        }
        public int DivideVal
        {
            get { return _DivideVal; }
            set
            {

                if (value > 10)
                    value = 10;
                if (value < 1)
                    value = 1;

                _DivideVal = value;
                Invalidate();
            }
        }
        public Double Value
        {
            get { return _Value; }
            set
            {
                _Value = value;
                Invalidate();
            }
        }
        public Double Maximum
        {
            get { return _Maximum; }
            set
            {
                _Maximum = value;
                Invalidate();
            }
        }
        public Double Minimum
        {
            get { return _Minimum; }
            set
            {
                _Minimum = value;
                Invalidate();
            }
        }
        public Color ProgressColorBase
        {
            get { return _ProgressColorBase; }
            set
            {
                _ProgressColorBase = value;
                Invalidate();
            }
        } 

        public _ProgressShape ProgressShape
        {
            get { return ProgressShapeVal; }
            set
            {
                ProgressShapeVal = value;
                Invalidate();
            }
        }

        public _AngleRangeStyle AngleRangeStyle
        {
            get { return AngleRangeVal; }
            set
            {
                AngleRangeVal = value;
                Invalidate();
            }
        }

        public _DecimalPlaces DecimalPlaces
        {
            get { return DecimalPlacesVal; }
            set
            {
                DecimalPlacesVal = value;
                Invalidate();
            }
        }
        #endregion

        #region EventArgs

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetStandardSize();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            SetStandardSize();
        }

        protected override void OnPaintBackground(PaintEventArgs p)
        {
            base.OnPaintBackground(p);
        }

        #endregion



        private void SetStandardSize()
        {
            //int _Size = Math.Max(Width, Height);

            int _Size = this.Width + 10;

            Size = new Size(this.Width, _Size);
        }

        public void Increment(int Val)
        {
            this._Value += Val;
            Invalidate();
        }

        public void Decrement(int Val)
        {
            this._Value -= Val;
            Invalidate();
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 게이지 라인 Round Style
            LineCap linecap;
            if (ProgressShapeVal == _ProgressShape.Round) linecap = LineCap.Round;
            else linecap = LineCap.Flat;


            // Auto 모드 일때 나누어진 마디 수에 따른 시작과 끝의 영역 세팅
            if (AngleRangeVal == _AngleRangeStyle.Auto)
            {           // Divide       1     2     3     4     5     6     7     8     9    10
                int[] startArr = { 0, -230, -230, -225, -230, -230, -225, -230, -230, -225, -230 };
                int[] rangeArr = { 0, 280, 280, 270, 280, 280, 270, 280, 280, 270, 280 };

                _startAngle = startArr[_DivideVal];
                _angleRange =  rangeArr[_DivideVal];
            }
            else { }

             
            double circleRatio = 0; // 좌측 상단 
            double zeroRatio = 0;   // 원의 크기 (값이 클 수록 원이 작어짐) 
            using (Bitmap bitmap = new Bitmap(this.Width, this.Height))
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.Clear(this.BackColor);
                    int thisOpacity = 255;


                    // ===== Value Progress Color 적용 
                    circleRatio = 0.66;
                    zeroRatio = (1 - circleRatio) / 2;
                    Color specColor;

                    if (_Value <= _specUp && _Value >= _specLow) specColor = _specColorIn;
                    else specColor = _specColorOut;

                    float valueRange = (280 / ((float)this._Maximum - (float)this.Minimum));

                    using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, specColor, specColor, LinearGradientMode.ForwardDiagonal))
                    {
                        using (Pen pen = new Pen(brush, Convert.ToInt32(2 + this.Width * 0.07)))
                        {
                            pen.StartCap = linecap;
                            pen.EndCap = linecap;

                            float reStartAngle;
                            float reApplyAngle; 

                            if (this._Minimum < 0 && this._Maximum >= 0)
                            {
                                reStartAngle = _startAngle - ((float)this.Minimum * valueRange);
                                reApplyAngle = (float)_Value * valueRange;
                            }
                            else if ( this._Maximum < 0)
                            {
                                reStartAngle = _startAngle - ((float)(this.Minimum - this._Maximum) * valueRange) * 1;
                                reApplyAngle = (float)_Value * valueRange - ((float)this._Maximum * valueRange);
                            }
                            else
                            {
                                reStartAngle = _startAngle;
                                reApplyAngle = (float)_Value * valueRange;
                            }

                            graphics.DrawArc(pen, Convert.ToInt32(this.Width * zeroRatio), Convert.ToInt32(this.Width * zeroRatio),
                                                (Convert.ToInt32(this.Width * circleRatio)), Convert.ToInt32(this.Width * circleRatio),
                                                reStartAngle, reApplyAngle);
                        }
                    }



                    // ===== Base(Guide) Progress Color 적용 

                    int beforeAngle = 0;
                    int afterAngle = 0;
                    int divideValue = _DivideVal;
                    int divideAngle = 0; 

                        // 마디 수량만큼 Line 그리기
                    divideAngle = _angleRange / divideValue;
                    for (int i = 0; i < divideValue; i++)
                    {
                        // 마디 순서 별 범위 적용
                        beforeAngle = _startAngle + divideAngle * (i);
                        afterAngle = divideAngle;
                         

                        // 마디 순서에 따라 Line 그리기
                        circleRatio = 0.66;
                        zeroRatio = (1 - circleRatio) / 2;
                        using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, _ProgressColorBase, _ProgressColorBase, LinearGradientMode.ForwardDiagonal))
                        {
                            using (Pen pen = new Pen(brush, Convert.ToInt32(this.Width * 0.01)))
                            {
                                pen.StartCap = linecap;
                                pen.EndCap = linecap;
                                graphics.DrawArc(pen, Convert.ToInt32(this.Width * zeroRatio), Convert.ToInt32(this.Width * zeroRatio),
                                                   (Convert.ToInt32(this.Width * circleRatio)), Convert.ToInt32(this.Width * circleRatio),
                                                    beforeAngle + blankVal, afterAngle - blankVal * 2);
                            }
                        }
                    }



                    // ===== Value 바늘 Circle //
                    circleRatio = 0.08;
                    zeroRatio = (1 - circleRatio) / 2;
                    Color pinCircleColor = Color.Black;
                    using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                               Color.FromArgb(thisOpacity, pinCircleColor), Color.FromArgb(thisOpacity, pinCircleColor),
                                               LinearGradientMode.ForwardDiagonal))
                    {
                        using (Pen pen = new Pen(brush, 2))
                        {
                            pen.StartCap = linecap;
                            pen.EndCap = linecap;

                            graphics.DrawArc(pen, Convert.ToInt32(this.Width * zeroRatio), Convert.ToInt32(this.Width * zeroRatio),
                                               (Convert.ToInt32(this.Width * circleRatio)), Convert.ToInt32(this.Width * circleRatio),
                                               0, 360);
                        }
                    }


                    // ===== Value 바늘 //
                    circleRatio = 0.38;
                    zeroRatio = (1 - circleRatio) / 2;
                    Color pinColor = Color.Black;
                    using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                                               Color.FromArgb(thisOpacity, pinColor), Color.FromArgb(thisOpacity, pinColor),
                                               LinearGradientMode.ForwardDiagonal))
                    {
                        using (Pen pen = new Pen(brush, Convert.ToInt32(this.Width * 0.3)))
                        {
                            float _offsetVal = 0.0f;

                            if (_Minimum < 0) 
                            {
                                _offsetVal = valueRange * (float)_Minimum;
                            }

                            pen.StartCap = LineCap.Flat;
                            pen.EndCap = LineCap.Flat;
                            graphics.DrawArc(pen, Convert.ToInt32(this.Width * zeroRatio), Convert.ToInt32(this.Width * zeroRatio),
                                               (Convert.ToInt32(this.Width * circleRatio)), Convert.ToInt32(this.Width * circleRatio),
                                               (int)Math.Round((double)(valueRange * this._Value - _offsetVal)) - 230 - 1, 2);
                        }
                    }


                    // ===== Value 보여주기 //
                    StringFormat sf = new StringFormat
                    {
                        Alignment = StringAlignment.Center
                    };
                    string strDP = "";
                    switch (DecimalPlacesVal)
                    {
                        case _DecimalPlaces.Non:
                            strDP = "";
                            break;

                        case _DecimalPlaces.첫번째:
                            strDP = "0.0";
                            break;

                        case _DecimalPlaces.두번째:
                            strDP = "0.00";
                            break;

                        case _DecimalPlaces.세번째:
                            strDP = "0.000";
                            break;
                    }
                    string strVal = (this._Value).ToString(strDP);
                    SizeF ms = graphics.MeasureString(Convert.ToString(strVal), this.Font);
                    float ms_X = this.Width / 2;
                    float ms_Y = this.Height - ms.Height + 2;

                    graphics.DrawString((this._Value).ToString(strDP), this.Font, new SolidBrush(specColor), ms_X, ms_Y, sf);




                    // ===== Max / Min 값 보여주기 //
                    SizeF msM = graphics.MeasureString(Convert.ToString(this._Minimum), this._minmaxFont);

                    float mTopX = (this.Width * 0.5f);
                    float mTopY = (this.Width * 0.3f) / 2;

                    float mXL = (this.Width * 0.3f) / 2;
                    float mXR = this.Width * 0.7f + mXL;
                    float mY = this.Height * 0.7f;

                    graphics.DrawString((this._Minimum).ToString(), this._minmaxFont, new SolidBrush(this._minmaxForeColor), mXL, mY + 3, sf);
                    graphics.DrawString((this._Maximum).ToString(), this._minmaxFont, new SolidBrush(this._minmaxForeColor), mXR, mY + 3, sf);
                    graphics.DrawString(((this._Maximum + this._Minimum) / 2).ToString(), this._minmaxFont, new SolidBrush(this._minmaxForeColor), mTopX, 0, sf);


                    e.Graphics.DrawImage(bitmap, 0, 0);
                    graphics.Dispose();
                    bitmap.Dispose();
                }
            }
        }


         


    }
}
