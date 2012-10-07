﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GalaSoft.MvvmLight;
using HandBrake.Interop.Model.Encoding;

namespace VidCoder.ViewModel
{
	using System.Resources;
	using LocalResources;

	public class AudioEncoderViewModel : ViewModelBase
	{
		private static ResourceManager manager = new ResourceManager(typeof(EncodingRes));

		public HBAudioEncoder Encoder { get; set; }

		public string Display
		{
			get
			{
				string resourceString = manager.GetString("AudioEncoder_" + this.Encoder.ShortName.Replace(':', '_'));

				if (string.IsNullOrWhiteSpace(resourceString))
				{
					return this.Encoder.DisplayName;
				}

				return resourceString;
			}
		}
	}
}
