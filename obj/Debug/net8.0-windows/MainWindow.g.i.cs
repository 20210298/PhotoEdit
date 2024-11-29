// Updated by XamlIntelliSenseFileGenerator 2024-11-30 오전 7:49:26
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7EFA9681D82B9505A1746E7EC1F30C6F2DFF629C"
//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using PhotoEdit;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace PhotoEdit
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 28 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border FileBox;

#line default
#line hidden


#line 45 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ImageBox;

#line default
#line hidden


#line 56 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border Select;

#line default
#line hidden


#line 57 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card Selector;

#line default
#line hidden


#line 66 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AdjustButton;

#line default
#line hidden


#line 75 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TransferButton;

#line default
#line hidden


#line 89 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ImageSheet;

#line default
#line hidden


#line 90 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImageDisplay1;

#line default
#line hidden


#line 93 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.ScaleTransform ImageScaleTransform;

#line default
#line hidden


#line 100 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadImgButton;

#line default
#line hidden


#line 106 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas CropCanvas;

#line default
#line hidden


#line 111 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle SelectionRectangle;

#line default
#line hidden


#line 142 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SliderGrid;

#line default
#line hidden


#line 144 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border tools;

#line default
#line hidden


#line 145 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card ToolBox;

#line default
#line hidden


#line 154 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExposureButton;

#line default
#line hidden


#line 159 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ShadowButton;

#line default
#line hidden


#line 165 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BrightnessButton;

#line default
#line hidden


#line 169 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ContrastButton;

#line default
#line hidden


#line 173 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ChromaButton;

#line default
#line hidden


#line 177 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HighlightButton;

#line default
#line hidden


#line 181 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ColorTmpButton;

#line default
#line hidden


#line 189 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border rotation;

#line default
#line hidden


#line 190 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.Card RotationBox;

#line default
#line hidden


#line 199 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button FlipButton;

#line default
#line hidden


#line 203 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MirrorButton;

#line default
#line hidden


#line 207 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RotateRightButton;

#line default
#line hidden


#line 211 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RotateLeftButton;

#line default
#line hidden


#line 221 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider Slider;

#line default
#line hidden


#line 248 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CompleteButton;

#line default
#line hidden


#line 258 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveButton;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PhotoEdit;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.8.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Main = ((PhotoEdit.MainWindow)(target));
                    return;
                case 2:
                    this.FileBox = ((System.Windows.Controls.Border)(target));
                    return;
                case 3:

#line 34 "..\..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.OpenImage);

#line default
#line hidden
                    return;
                case 4:

#line 36 "..\..\..\MainWindow.xaml"
                    ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SaveAsImage);

#line default
#line hidden
                    return;
                case 5:
                    this.ImageBox = ((System.Windows.Controls.Border)(target));
                    return;
                case 6:
                    this.Select = ((System.Windows.Controls.Border)(target));
                    return;
                case 7:
                    this.Selector = ((MaterialDesignThemes.Wpf.Card)(target));
                    return;
                case 8:
                    this.AdjustButton = ((System.Windows.Controls.Button)(target));

#line 69 "..\..\..\MainWindow.xaml"
                    this.AdjustButton.Click += new System.Windows.RoutedEventHandler(this.AdjustButton_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.TransferButton = ((System.Windows.Controls.Button)(target));

#line 80 "..\..\..\MainWindow.xaml"
                    this.TransferButton.Click += new System.Windows.RoutedEventHandler(this.TransferButton_Click);

#line default
#line hidden
                    return;
                case 10:
                    this.ImageSheet = ((System.Windows.Controls.Border)(target));
                    return;
                case 11:
                    this.ImageDisplay1 = ((System.Windows.Controls.Image)(target));
                    return;
                case 12:
                    this.ImageScaleTransform = ((System.Windows.Media.ScaleTransform)(target));
                    return;
                case 13:
                    this.LoadImgButton = ((System.Windows.Controls.Button)(target));

#line 101 "..\..\..\MainWindow.xaml"
                    this.LoadImgButton.Click += new System.Windows.RoutedEventHandler(this.LoadImgButton_Click);

#line default
#line hidden
                    return;
                case 14:
                    this.CropCanvas = ((System.Windows.Controls.Canvas)(target));

#line 107 "..\..\..\MainWindow.xaml"
                    this.CropCanvas.MouseWheel += new System.Windows.Input.MouseWheelEventHandler(this.CropCanvas_MouseWheel);

#line default
#line hidden
                    return;
                case 15:
                    this.SelectionRectangle = ((System.Windows.Shapes.Rectangle)(target));
                    return;
                case 16:
                    this.SliderGrid = ((System.Windows.Controls.Grid)(target));
                    return;
                case 17:
                    this.tools = ((System.Windows.Controls.Border)(target));
                    return;
                case 18:
                    this.ToolBox = ((MaterialDesignThemes.Wpf.Card)(target));
                    return;
                case 19:
                    this.ExposureButton = ((System.Windows.Controls.Button)(target));

#line 155 "..\..\..\MainWindow.xaml"
                    this.ExposureButton.Click += new System.Windows.RoutedEventHandler(this.ExposureButton_Click);

#line default
#line hidden
                    return;
                case 20:
                    this.ShadowButton = ((System.Windows.Controls.Button)(target));

#line 161 "..\..\..\MainWindow.xaml"
                    this.ShadowButton.Click += new System.Windows.RoutedEventHandler(this.ShadowButton_Click);

#line default
#line hidden
                    return;
                case 21:
                    this.BrightnessButton = ((System.Windows.Controls.Button)(target));

#line 166 "..\..\..\MainWindow.xaml"
                    this.BrightnessButton.Click += new System.Windows.RoutedEventHandler(this.BrightnessButton_Click);

#line default
#line hidden
                    return;
                case 22:
                    this.ContrastButton = ((System.Windows.Controls.Button)(target));

#line 170 "..\..\..\MainWindow.xaml"
                    this.ContrastButton.Click += new System.Windows.RoutedEventHandler(this.ContrastButton_Click);

#line default
#line hidden
                    return;
                case 23:
                    this.ChromaButton = ((System.Windows.Controls.Button)(target));

#line 174 "..\..\..\MainWindow.xaml"
                    this.ChromaButton.Click += new System.Windows.RoutedEventHandler(this.ChromaButton_Click);

#line default
#line hidden
                    return;
                case 24:
                    this.HighlightButton = ((System.Windows.Controls.Button)(target));

#line 178 "..\..\..\MainWindow.xaml"
                    this.HighlightButton.Click += new System.Windows.RoutedEventHandler(this.HighlightButton_Click);

#line default
#line hidden
                    return;
                case 25:
                    this.ColorTmpButton = ((System.Windows.Controls.Button)(target));

#line 182 "..\..\..\MainWindow.xaml"
                    this.ColorTmpButton.Click += new System.Windows.RoutedEventHandler(this.ColorTmpButton_Click);

#line default
#line hidden
                    return;
                case 26:
                    this.rotation = ((System.Windows.Controls.Border)(target));
                    return;
                case 27:
                    this.RotationBox = ((MaterialDesignThemes.Wpf.Card)(target));
                    return;
                case 28:
                    this.FlipButton = ((System.Windows.Controls.Button)(target));

#line 200 "..\..\..\MainWindow.xaml"
                    this.FlipButton.Click += new System.Windows.RoutedEventHandler(this.FlipButton_Click);

#line default
#line hidden
                    return;
                case 29:
                    this.MirrorButton = ((System.Windows.Controls.Button)(target));

#line 204 "..\..\..\MainWindow.xaml"
                    this.MirrorButton.Click += new System.Windows.RoutedEventHandler(this.MirrorButton_Click);

#line default
#line hidden
                    return;
                case 30:
                    this.RotateRightButton = ((System.Windows.Controls.Button)(target));

#line 208 "..\..\..\MainWindow.xaml"
                    this.RotateRightButton.Click += new System.Windows.RoutedEventHandler(this.RotateRightButton_Click);

#line default
#line hidden
                    return;
                case 31:
                    this.RotateLeftButton = ((System.Windows.Controls.Button)(target));

#line 212 "..\..\..\MainWindow.xaml"
                    this.RotateLeftButton.Click += new System.Windows.RoutedEventHandler(this.RotateLeftButton_Click);

#line default
#line hidden
                    return;
                case 32:
                    this.Slider = ((System.Windows.Controls.Slider)(target));

#line 231 "..\..\..\MainWindow.xaml"
                    this.Slider.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.Slider_ValueChanged);

#line default
#line hidden
                    return;
                case 33:
                    this.CompleteButton = ((System.Windows.Controls.Button)(target));

#line 249 "..\..\..\MainWindow.xaml"
                    this.CompleteButton.Click += new System.Windows.RoutedEventHandler(this.CompleteButton_Click);

#line default
#line hidden
                    return;
                case 34:
                    this.SaveButton = ((System.Windows.Controls.Button)(target));

#line 259 "..\..\..\MainWindow.xaml"
                    this.SaveButton.Click += new System.Windows.RoutedEventHandler(this.SaveButton_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window Main;
    }
}

