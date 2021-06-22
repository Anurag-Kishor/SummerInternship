using System;
using System.Collections.Generic;
using System.Text;

namespace LearnXAML
{
    class PageDataViewModel
    {
        public Type Type { private set; get; }
        public string Title { private set; get;  }

        public string Description { private set; get; }
        
        public static IList<PageDataViewModel> All { private set; get; }
        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {
                new PageDataViewModel(typeof(HelloXaml), "Hello, Xaml", "Display a Label with many properties set"),
                new PageDataViewModel(typeof(XamlPlusCodePage), "XAML + Code", 
                                    "Interact with a Slider and Button"),
                new PageDataViewModel(typeof(GridDemo), "Grid Demo",
                                  "Explore XAML syntax with the Grid"),
                new PageDataViewModel(typeof(AbsoluteDemoPage), "Absolute Demo",
                                  "Explore XAML syntax with AbsoluteLayout"),
                
                new PageDataViewModel(typeof(RelativeLayoutPage), "Relative Layout",
                                        "Explore XAML markup extensions"),

                new PageDataViewModel(typeof(SliderBindingPage), "Slider Bindings",
                                        "Bind properties of two views on the page"),

                new PageDataViewModel(typeof(SliderTransformsPage), "Slider Transforms",
                                        "Use Sliders with reverse bindings"),

                new PageDataViewModel(typeof(ListViewDemoPage), "ListView Demo",
                                        "Use a ListView with data bindings"),

                new PageDataViewModel(typeof(DateTimePage), "One-Shot DateTime",
                                        "Obtain the current DateTime and display it"),

                new PageDataViewModel(typeof(ClockPage), "Clock",
                                        "Dynamically display the current time"),

                new PageDataViewModel(typeof(HslColorScrollPage), "HSL Color Scroll",
                                        "Use a view model to select HSL colors"),

                new PageDataViewModel(typeof(KeypadPage), "Keypad",
                                        "Use a view model for numeric keypad logic")

            };
        }
    }
}
