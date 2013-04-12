using System;
using System.Collections.Generic;

using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;
using System.Globalization;

namespace WTJoystickCurves
{
    class Profile
    {
        private const string reSection = @"\{[^\}]*\}";
        private const string reSliders =
                @"nonLinearitySlider0:r=([\d\.]+)[^\}]*" +
                @"nonLinearitySlider1:r=([\d\.]+)[^\}]*" +
                @"nonLinearitySlider2:r=([\d\.]+)[^\}]*" +
                @"nonLinearitySlider3:r=([\d\.]+)[^\}]*" +
                @"nonLinearitySlider4:r=([\d\.]+)[^\}]*" +
                @"nonLinearitySlider5:r=([\d\.]+)[^\}]*" +
                @"nonLinearitySlider6:r=([\d\.]+)[^\}]*" +
                @"nonLinearitySlider7:r=([\d\.]+)[^\}]*" +
                @"nonLinearitySlider8:r=([\d\.]+)[^\}]*" +
                @"nonLinearitySlider9:r=([\d\.]+)[^\}]*";

        private string _path;
        private string _content;
        public Profile(string path)
        {
            Initialized = false;
            _path = path;
            try
            {
                _content = File.ReadAllText(_path, Encoding.UTF8);
                if (String.IsNullOrEmpty(_content))
                    return;
            }
            catch {
                return;
            }
            
            if( String.IsNullOrEmpty(_content ) )
                return;

            Initialized = true;
        }
        public bool Initialized
        {
            get;
            set;
        }
        public float[] GetLinearitySliders( string section )
        {
            if (String.IsNullOrEmpty(_content))
                return new float[10];

            var sectionText = Re.GetSubString( _content, "(" + section + reSection + ")",1 );

            if (String.IsNullOrEmpty(sectionText))
                return new float[10];

            Debug.Print(sectionText);

            float[] sliders = new float[10];
            float outValue;
            for (var i = 0; i < sliders.Length; i++)
            {
                var number = Re.GetSubString(sectionText, reSliders, i + 1);
                float.TryParse(number, NumberStyles.Any, CultureInfo.InvariantCulture, out outValue);
                sliders[i] = outValue;
            }

            return sliders;
        }

        public void SetLinearitySliders(string section, float[] sliders)
        {
            if (sliders == null)
                return;

            if (sliders.Length != 10)
                return;
            for( var i = 0; i<sliders.Length; i++ )
            {
                var reSlider = @"^(.*[^a-z_0-9]+" 
                            + section 
                            + @"\{[^\}]*nonLinearitySlider"
                            + i.ToString()
                            + @":r=)[\d\.]+(.*)$";
                _content = Regex.Replace(_content, reSlider, m => m.Groups[1] + sliders[i].ToString().Replace(",",".") + m.Groups[2], RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }

        }

        public bool GetSliderCheckState(string section)
        {
            if (String.IsNullOrEmpty(_content))
                return false;

            var reSliderCheckState = @"^(.*[^a-z_0-9]+"
                        + section
                        + @"\{[^\}]*useSliders:b=)([a-z]+)(.*)$";
            
            return (Re.GetSubString(_content, reSliderCheckState, 2) == "no"?false:true);
        }

        public void SetSliderCheckState(string section, bool checkedState)
        {
            if (String.IsNullOrEmpty(_content))
                return;

            var reSliderCheckState = @"^(.*[^a-z_0-9]+"
                        + section
                        + @"\{[^\}]*useSliders:b=)([a-z]+)(.*)$";
            
            _content = Regex.Replace(_content, reSliderCheckState, "$1" + (checkedState?"yes":"no") + "$3", RegexOptions.IgnoreCase | RegexOptions.Singleline);
        }

        public bool Save()
        {
            var result = false;
            try
            {
                if (String.IsNullOrEmpty(_content))
                    return false;

                File.WriteAllText(_path, _content);
                result = true;
            }
            catch
            {
            }

            return result;

        }

    }
}
