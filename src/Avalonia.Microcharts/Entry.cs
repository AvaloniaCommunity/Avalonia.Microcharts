﻿using SkiaSharp;

namespace Avalonia.Microcharts
{
    /// <summary>
	/// A data entry for a chart.
	/// </summary>
	public class Entry
	{
        /// <summary>
		/// Gets the value.
		/// </summary>
		/// <value>The value.</value>
		public float Value { get; set; }

		/// <summary>
		/// Gets or sets the caption label.
		/// </summary>
		/// <value>The label.</value>
		public string Label { get; set; }

		/// <summary>
		/// Gets or sets the label associated to the value.
		/// </summary>
		/// <value>The value label.</value>
		public string ValueLabel { get; set; }

		/// <summary>
		/// Gets or sets the color of the fill.
		/// </summary>
		/// <value>The color of the fill.</value>
		public SKColor Color { get; set; } = SKColors.Black;

		/// <summary>
		/// Gets or sets the color of the text (for the caption label).
		/// </summary>
		/// <value>The color of the text.</value>
		public SKColor TextColor { get; set; } = SKColors.Gray;
    }
}
