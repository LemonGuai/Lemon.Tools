﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GptApi.Models
{
	public class Message
	{
		public string Role { get; set; }
		public string Content { get; set; }
		public string Name { get; set; }
	}
}
