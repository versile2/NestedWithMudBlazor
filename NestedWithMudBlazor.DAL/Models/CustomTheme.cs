using MudBlazor;

namespace NestedWithMudBlazor.DAL.Models
{
    public class CustomTheme
    {
        public static readonly MudTheme SilverTheme = new()
        {
            PaletteLight = new PaletteLight()
            {
                Primary = "#1984c8",
                PrimaryContrastText = "#FFFFFF",
                Secondary = "#f3f3f4",
                SecondaryContrastText = "#FFFFFF",
                Tertiary = "#03a9f4",
                TertiaryContrastText = "#FFFFFF",
                Info = "#007bc3",
                Success = "#3ea44e",
                Warning = "#ff9800",
                Error = "#d92800",
                Dark = "#404040",
                DarkLighten = "#ebebeb",
                TextDisabled = "#8f8f8f",
                Background = "#ffffff",
                TextPrimary = "#515967",
                TextSecondary = "#666666",
                AppbarBackground = "#364258",
                AppbarText = "#ffffff",
                DrawerBackground = "#798eab",
                DrawerText = "#ffffff",
            },
            PaletteDark = new PaletteDark()
            {
                Primary = "#1984c8",
                Secondary = "#131314",
                Tertiary = "#03a9f4",
                Info = "#007bc3",
                Success = "#3ea44e",
                Warning = "#ff9800",
                Error = "#d92800",
                Dark = "#404040",
                DarkLighten = "#ebebeb",
                TextDisabled = "#d0d0d0",
                Background = "#000000",
                TextPrimary = "#ffffff",
                TextSecondary = "#e0e0e0",
                AppbarBackground = "#364258",
                AppbarText = "#ffffff",
                DrawerBackground = "#798eab",
                DrawerText = "#ffffff",
            },
            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "4px",
            },
            Typography = new Typography()
            {
                Default = new DefaultTypography()
                {
                    FontWeight = "400",
                    LineHeight = "1.4285714287",
                    FontFamily = ["Source Sans Pro", "Helvetica Neue", "Arial", "sans-serif"],
                },
                Body1 = new Body1Typography()
                {
                    FontSize = "14px",
                },
                Body2 = new Body2Typography()
                {
                    FontSize = "12px",
                },
            }
        };

        /* 
!
* Bootswatch v5.3.3 (https://bootswatch.com)
* Theme: cyborg
* Copyright 2012-2024 Thomas Park
* Licensed under MIT
* Based on Bootstrap
*/
        public static readonly MudTheme Cyborgtheme = new()
        {
            PaletteLight = new PaletteLight()
            {
                WarningLighten = "#ffe7cc",
                ErrorDarken = "rgb(242,28,13)",
                ErrorLighten = "rgb(246,96,85)",
                DarkDarken = "#1c1818ff",
                DarkLighten = "#808080ff",
                HoverOpacity = 0.06,
                RippleOpacity = 0.1,
                RippleOpacitySecondary = 0.2,
                GrayDefault = "#9E9E9E",
                GrayLight = "#BDBDBD",
                GrayLighter = "#E0E0E0",
                GrayDark = "#757575",
                GrayDarker = "#616161",
                OverlayDark = "rgba(33,33,33,0.4980392156862745)",
                OverlayLight = "rgba(255,255,255,0.4980392156862745)",
                Black = "#000",
                White = "#fff",
                Primary = "#2a9fd6ff",
                PrimaryContrastText = "#d4ecf7ff",
                Secondary = "#555",
                SecondaryContrastText = "#dddddd",
                Tertiary = "#74f6b7ff",
                TertiaryContrastText = "#000000ff",
                Info = "#93c",
                InfoContrastText = "#ebd6f5",
                Success = "#77b300",
                SuccessContrastText = "#e4f0cc",
                Warning = "#f80",
                WarningContrastText = "#ffe7cc",
                Error = "rgba(244,67,54,1)",
                ErrorContrastText = "rgba(255,255,255,1)",
                Dark = "#414141ff",
                DarkContrastText = "#adafaeff",
                TextPrimary = "#d4e7edff",
                TextSecondary = "#888686ff",
                TextDisabled = "rgba(0,0,0,0.3764705882352941)",
                ActionDefault = "#d4e7edff",
                ActionDisabled = "rgba(0,0,0,0.25882352941176473)",
                ActionDisabledBackground = "rgba(0,0,0,0.11764705882352941)",
                Background = "#050505ff",
                BackgroundGray = "rgba(245,245,245,1)",
                Surface = "#050505ff",
                DrawerBackground = "#252121ff",
                DrawerText = "#555555ff",
                DrawerIcon = "#555",
                AppbarBackground = "#d4ecf7ff",
                AppbarText = "#2a9fd6",
                LinesDefault = "rgba(0,0,0,0.11764705882352941)",
                LinesInputs = "rgba(189,189,189,1)",
                TableLines = "rgba(224,224,224,1)",
                TableStriped = "rgba(0,0,0,0.0196078431372549)",
                TableHover = "rgba(0,0,0,0.0392156862745098)",
                Divider = "rgba(224,224,224,1)",
                DividerLight = "rgba(0,0,0,0.8)",
                PrimaryDarken = "#114056",
                PrimaryLighten = "#d4ecf7ff",
                SecondaryDarken = "#222222",
                SecondaryLighten = "#dddddd",
                TertiaryDarken = "#3bc180ff",
                TertiaryLighten = "#affbd6ff",
                InfoDarken = "#3d1452",
                InfoLighten = "#ebd6f5",
                SuccessDarken = "#304800",
                SuccessLighten = "#e4f0cc",
                WarningDarken = "#663600",
            },
            PaletteDark = new PaletteDark()
            {
                WarningLighten = "#331b00",
                ErrorDarken = "rgb(242,28,13)",
                ErrorLighten = "rgb(246,96,85)",
                DarkDarken = "rgb(23,23,28)",
                DarkLighten = "rgb(56,56,67)",
                Black = "#000",
                White = "#fff",
                Primary = "#2a9fd6",
                PrimaryContrastText = "#d4ecf7ff",
                Secondary = "#555",
                SecondaryContrastText = "#d4ecf7ff",
                Tertiary = "#74f6b7ff",
                TertiaryContrastText = "#000000ff",
                Info = "#93c",
                InfoContrastText = "#1f0a29",
                Success = "#77b300",
                SuccessContrastText = "#182400",
                Warning = "#f80",
                WarningContrastText = "#331b00",
                Error = "rgba(244,67,54,1)",
                ErrorContrastText = "rgba(255,255,255,1)",
                Dark = "#adafae",
                DarkContrastText = "#111111",
                TextPrimary = "#d4e7edff",
                TextSecondary = "#999999",
                TextDisabled = "rgba(255,255,255,0.2)",
                ActionDefault = "rgba(173,173,177,1)",
                ActionDisabled = "rgba(255,255,255,0.25882352941176473)",
                ActionDisabledBackground = "rgba(255,255,255,0.11764705882352941)",
                Background = "rgba(50,51,61,1)",
                BackgroundGray = "rgba(39,39,47,1)",
                Surface = "rgba(55,55,64,1)",
                DrawerBackground = "#111111",
                DrawerText = "#555",
                DrawerIcon = "#555",
                AppbarBackground = "#08202b",
                AppbarText = "#2a9fd6",
                LinesDefault = "rgba(255,255,255,0.11764705882352941)",
                LinesInputs = "rgba(255,255,255,0.2980392156862745)",
                TableLines = "rgba(255,255,255,0.11764705882352941)",
                TableStriped = "rgba(255,255,255,0.2)",
                Divider = "rgba(255,255,255,0.11764705882352941)",
                DividerLight = "rgba(255,255,255,0.058823529411764705)",
                PrimaryDarken = "#7fc5e6",
                PrimaryLighten = "#08202b",
                SecondaryDarken = "#999999",
                SecondaryLighten = "#111111",
                TertiaryDarken = "#3bc180ff",
                TertiaryLighten = "#affbd6ff",
                InfoDarken = "#c285e0",
                InfoLighten = "#1f0a29",
                SuccessDarken = "#add166",
                SuccessLighten = "#182400",
                WarningDarken = "#ffb866",
            },
            LayoutProperties = new LayoutProperties()
            {
                DefaultBorderRadius = "4px",
                DrawerMiniWidthLeft = "56px",
                DrawerMiniWidthRight = "56px",
                DrawerWidthLeft = "240px",
                DrawerWidthRight = "240px",
                AppbarHeight = "64px",
            },
            Typography = new Typography()
            {
                Default = new DefaultTypography
                {
                    FontFamily = ["Roboto", "Helvetica", "Arial", "sans-serif"],
                    FontWeight = "400",
                    FontSize = ".875rem",
                    LineHeight = "1.43",
                    LetterSpacing = ".01071em",
                    TextTransform = "none",
                },
                H1 = new H1Typography
                {
                    FontWeight = "300",
                    FontSize = "6rem",
                    LineHeight = "1.167",
                    LetterSpacing = "-.01562em",
                    TextTransform = "none",
                },
                H2 = new H2Typography
                {
                    FontWeight = "300",
                    FontSize = "3.75rem",
                    LineHeight = "1.2",
                    LetterSpacing = "-.00833em",
                    TextTransform = "none",
                },
                H3 = new H3Typography
                {
                    FontWeight = "400",
                    FontSize = "3rem",
                    LineHeight = "1.167",
                    LetterSpacing = "0",
                    TextTransform = "none",
                },
                H4 = new H4Typography
                {
                    FontWeight = "400",
                    FontSize = "2.125rem",
                    LineHeight = "1.235",
                    LetterSpacing = ".00735em",
                    TextTransform = "none",
                },
                H5 = new H5Typography
                {
                    FontWeight = "400",
                    FontSize = "1.5rem",
                    LineHeight = "1.334",
                    LetterSpacing = "0",
                    TextTransform = "none",
                },
                H6 = new H6Typography
                {
                    FontWeight = "500",
                    FontSize = "1.25rem",
                    LineHeight = "1.6",
                    LetterSpacing = ".0075em",
                    TextTransform = "none",
                },
                Subtitle1 = new Subtitle1Typography
                {
                    FontWeight = "400",
                    FontSize = "1rem",
                    LineHeight = "1.75",
                    LetterSpacing = ".00938em",
                    TextTransform = "none",
                },
                Subtitle2 = new Subtitle2Typography
                {
                    FontWeight = "500",
                    FontSize = ".875rem",
                    LineHeight = "1.57",
                    LetterSpacing = ".00714em",
                    TextTransform = "none",
                },
                Body1 = new Body1Typography
                {
                    FontWeight = "400",
                    FontSize = "1rem",
                    LineHeight = "1.5",
                    LetterSpacing = ".00938em",
                    TextTransform = "none",
                },
                Body2 = new Body2Typography
                {
                    FontWeight = "400",
                    FontSize = ".875rem",
                    LineHeight = "1.43",
                    LetterSpacing = ".01071em",
                    TextTransform = "none",
                },
                Button = new ButtonTypography
                {
                    FontWeight = "500",
                    FontSize = ".875rem",
                    LineHeight = "1.75",
                    LetterSpacing = ".02857em",
                    TextTransform = "uppercase",
                },
                Caption = new CaptionTypography
                {
                    FontWeight = "400",
                    FontSize = ".75rem",
                    LineHeight = "1.66",
                    LetterSpacing = ".03333em",
                    TextTransform = "none",
                },
                Overline = new OverlineTypography
                {
                    FontWeight = "400",
                    FontSize = ".75rem",
                    LineHeight = "2.66",
                    LetterSpacing = ".08333em",
                    TextTransform = "none",
                },
            },
            ZIndex = new ZIndex()
            {
                Drawer = 1100,
                Popover = 1200,
                AppBar = 1300,
                Dialog = 1400,
                Snackbar = 1500,
                Tooltip = 1600,
            },
        };

    }
}