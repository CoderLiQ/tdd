﻿using System.Drawing;

namespace TagsCloudVisualization
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                var layouter = new CircularCloudLayouter(new Point(1000, 1000));
                var rectangles = CircularCloudLayouterGenerator.GenerateRectanglesSet(layouter, 50, 100, 150, 50, 75);
                CircularCloudLayouterDrawer.DrawRectanglesSet(layouter.Size, $"tag-cloud-{i + 1}.png", rectangles);
            }
        }
        
    }
}
