namespace Kendo.Mvc.UI.Fluent
{
    using System;
    using System.Collections.Generic;
    /// <summary>
    /// Defines the fluent interface for configuring the <see cref="DatePickerBase"/> component.
    /// </summary>
    public class ColorPaletteBuilder : WidgetBuilderBase<ColorPalette, ColorPaletteBuilder>, IHideObjectMembers
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ColorPaletteBuilder"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        public ColorPaletteBuilder(ColorPalette component)
            : base(component)
        {
        }

        /// <summary>
        /// Configures the client-side events.
        /// </summary>
        /// <param name="clientEventsAction">The client events action.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ColorPalette()
        ///             .Name("ColorPalette")
        ///             .Events(events =>
        ///                 events.Select("select").Change("change")
        ///             )
        /// %&gt;
        /// </code>
        /// </example>
        public ColorPaletteBuilder Events(Action<ColorPickerEventBuilder> clientEventsAction)
        {
            clientEventsAction(new ColorPickerEventBuilder(Component.Events));

            return this;
        }

        /// <summary>
        /// Sets the value of the picker input
        /// </summary>
        /// <param name="color">The initially selected color</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ColorPalette()
        ///             .Name("ColorPalette")
        ///             .Value("#ff0000")
        /// %&gt;
        /// </code>
        /// </example>
        public ColorPaletteBuilder Value(string color)
        {
            Component.Value = color;

            return this;
        }
        
        /// <summary>
        /// Sets the range of colors that the user can pick from.
        /// </summary>
        /// <param name="palette">A list of colors.</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ColorPalette()
        ///             .Name("ColorPalette")
        ///             .Palette(new List&lt;string&gt; { "#ff0000", "#00ff00", "#0000ff" })
        /// %&gt;
        /// </code>
        /// </example>
        public ColorPaletteBuilder Palette(IEnumerable<string> palette)
        {
            Component.PaletteColors = palette;
            Component.Palette = ColorPickerPalette.None;

            return this;
        }

        /// <summary>
        /// Sets the range of colors that the user can pick from.
        /// </summary>
        /// <param name="palette">One of the preset palettes of colors</param>
        /// <example>
        /// <code lang="CS">
        ///  &lt;%= Html.Kendo().ColorPalette()
        ///             .Name("ColorPalette")
        ///             .Palette(ColorPickerPalette.WebSafe)
        /// %&gt;
        /// </code>
        /// </example>
        public ColorPaletteBuilder Palette(ColorPickerPalette palette)
        {
            Component.PaletteColors = null;
            Component.Palette = palette;

            return this;
        }
    }
}