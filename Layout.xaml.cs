namespace Lessons_Net_Maui;

public partial class Layout : ContentPage
{
	public Layout()
	{
		InitializeComponent();

        // stacklayout
        tipPercentSlider.ValueChanged += (s, e) =>
        {
            double pct = Math.Round(e.NewValue);
            tipPercent.Text = pct + "%";
            CalculateTip(false, false);
        };

        // grid
        tipPercentSliderGrid.ValueChanged += (s, e) =>
        {
            double pct2 = Math.Round(e.NewValue);
            tipPercentGrid.Text = pct2 + "%";
            CalculateTipGrid(false, false);
        };

    }

    void CalculateTip(bool roundUp, bool roundDown)
    {
        double t;
        if (Double.TryParse(billInput.Text, out t) && t > 0)
        {
            double pct = Math.Round(tipPercentSlider.Value);
            double tip = Math.Round(t * (pct / 100.0), 2);

            double final = t + tip;

            if (roundUp)
            {
                final = Math.Ceiling(final);
                tip = final - t;
            }
            else if (roundDown)
            {
                final = Math.Floor(final);
                tip = final - t;
            }

            tipOutput.Text = tip.ToString("C");
            totalOutput.Text = final.ToString("C");
        }
    }

    void CalculateTipGrid(bool roundUpGrid, bool roundDownGrid)
    {
        double t;
        if (Double.TryParse(billInputGrid.Text, out t) && t > 0)
        {
            double pct = Math.Round(tipPercentSliderGrid.Value);
            double tip = Math.Round(t * (pct / 100.0), 2);

            double final = t + tip;

            if (roundUpGrid)
            {
                final = Math.Ceiling(final);
                tip = final - t;
            }
            else if (roundDownGrid)
            {
                final = Math.Floor(final);
                tip = final - t;
            }

            tipOutputGrid.Text = tip.ToString("C");
            totalOutputGrid.Text = final.ToString("C");
        }
    }


    void OnNormalTip(object sender, EventArgs e)
    {
        tipPercentSlider.Value = 15;
        tipPercentSliderGrid.Value = 15;
    }

    void OnGenerousTip(object sender, EventArgs e)
    { 
        tipPercentSlider.Value = 20;
        tipPercentSliderGrid.Value = 20;
    }

    private void horizontalStart_Clicked(object sender, EventArgs e)
    {
        labelHello.HorizontalOptions = LayoutOptions.Start;
    }

    private void horizontalCentr_Clicked(object sender, EventArgs e)
    {
        labelHello.HorizontalOptions = LayoutOptions.Center;
    }

    private void horizontalEnd_Clicked(object sender, EventArgs e)
    {
        labelHello.HorizontalOptions = LayoutOptions.End;
    }

    private void horizontalFill_Clicked(object sender, EventArgs e)
    {
        labelHello.HorizontalOptions = LayoutOptions.Fill;
    }

    private void verticalStart_Clicked(object sender, EventArgs e)
    {
        labelHello.VerticalOptions = LayoutOptions.Start;
    }

    private void verticalCentr_Clicked(object sender, EventArgs e)
    {
        labelHello.VerticalOptions = LayoutOptions.Center;
    }

    private void verticalEnd_Clicked(object sender, EventArgs e)
    {
        labelHello.VerticalOptions = LayoutOptions.End;
    }

    private void verticalFill_Clicked(object sender, EventArgs e)
    {
        labelHello.VerticalOptions = LayoutOptions.Fill;
    }
}