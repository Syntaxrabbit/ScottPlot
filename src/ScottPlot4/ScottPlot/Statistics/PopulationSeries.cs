using System;
using System.Collections.Generic;
using System.Text;

namespace ScottPlot.Statistics
{
    /// <summary>
    /// A population series is a collection of similar PopulationStats objects.
    /// </summary>
    public class PopulationSeries
    {
        public Population[] populations;
        public string seriesLabel;
        public System.Drawing.Color color;
        public System.Drawing.Color hatchColor;
        public ScottPlot.Drawing.HatchStyle hatchStyle;

        public PopulationSeries(Population[] populations, string seriesLabel = null, System.Drawing.Color? color = null, System.Drawing.Color? hatchColor = null, ScottPlot.Drawing.HatchStyle hatchStyle = ScottPlot.Drawing.HatchStyle.None)
        {
            this.populations = populations;
            this.seriesLabel = seriesLabel;
            this.color = (color is null) ? System.Drawing.Color.LightGray : color.Value;
            this.hatchColor = (hatchColor is null) ? System.Drawing.Color.DarkGray : hatchColor.Value;
            this.hatchStyle = hatchStyle;
        }
    }
}
