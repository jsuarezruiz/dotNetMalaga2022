﻿using Microsoft.Maui.Controls.Shapes;

namespace AlohaKit.UI
{
    public abstract class Shape : View
    {
        public static readonly BindableProperty FillProperty =      
            BindableProperty.Create(nameof(Fill), typeof(Brush), typeof(Shape), null,
                propertyChanged: InvalidatePropertyChanged);

        public static readonly BindableProperty StrokeProperty =
            BindableProperty.Create(nameof(Stroke), typeof(Brush), typeof(Shape), null,
                propertyChanged: InvalidatePropertyChanged);

        public static readonly BindableProperty StrokeThicknessProperty =
            BindableProperty.Create(nameof(StrokeThickness), typeof(double), typeof(Shape), 1.0,
                propertyChanged: InvalidatePropertyChanged);

        public static readonly BindableProperty StrokeDashArrayProperty =
            BindableProperty.Create(nameof(StrokeDashArray), typeof(DoubleCollection), typeof(Shape), null,
                defaultValueCreator: bindable => new DoubleCollection(), propertyChanged: InvalidatePropertyChanged);

        public static readonly BindableProperty StrokeDashOffsetProperty =
            BindableProperty.Create(nameof(StrokeDashOffset), typeof(double), typeof(Shape), 0.0,
                propertyChanged: InvalidatePropertyChanged);

        public static readonly BindableProperty StrokeLineCapProperty =
            BindableProperty.Create(nameof(StrokeLineCap), typeof(PenLineCap), typeof(Shape), PenLineCap.Flat,
                propertyChanged: InvalidatePropertyChanged);

        public static readonly BindableProperty StrokeLineJoinProperty =
            BindableProperty.Create(nameof(StrokeLineJoin), typeof(PenLineJoin), typeof(Shape), PenLineJoin.Miter,
                propertyChanged: InvalidatePropertyChanged);

        public static readonly BindableProperty StrokeMiterLimitProperty =
            BindableProperty.Create(nameof(StrokeMiterLimit), typeof(double), typeof(Shape), 10.0,
                propertyChanged: InvalidatePropertyChanged);

        public Brush Fill
        {
            set { SetValue(FillProperty, value); }
            get { return (Brush)GetValue(FillProperty); }
        }

        public Brush Stroke
        {
            set { SetValue(StrokeProperty, value); }
            get { return (Brush)GetValue(StrokeProperty); }
        }

        public double StrokeThickness
        {
            set { SetValue(StrokeThicknessProperty, value); }
            get { return (double)GetValue(StrokeThicknessProperty); }
        }
        public DoubleCollection StrokeDashArray
        {
            set { SetValue(StrokeDashArrayProperty, value); }
            get { return (DoubleCollection)GetValue(StrokeDashArrayProperty); }
        }

        public double StrokeDashOffset
        {
            set { SetValue(StrokeDashOffsetProperty, value); }
            get { return (double)GetValue(StrokeDashOffsetProperty); }
        }

        public PenLineCap StrokeLineCap
        {
            set { SetValue(StrokeLineCapProperty, value); }
            get { return (PenLineCap)GetValue(StrokeLineCapProperty); }
        }

        public PenLineJoin StrokeLineJoin
        {
            set { SetValue(StrokeLineJoinProperty, value); }
            get { return (PenLineJoin)GetValue(StrokeLineJoinProperty); }
        }

        public double StrokeMiterLimit
        {
            set { SetValue(StrokeMiterLimitProperty, value); }
            get { return (double)GetValue(StrokeMiterLimitProperty); }
        }
    }
}