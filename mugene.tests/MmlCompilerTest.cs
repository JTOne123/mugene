﻿using NUnit.Framework;
using System;
using Commons.Music.Midi.Mml;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Commons.Music.Midi.Mml.Tests
{
	[TestFixture]
	public class MmlCompilerTest
	{
		[Test]
		public void SimpleCompilation ()
		{
			MmlTestUtility.TestCompile ("SimpleCompilation", "1   o5cde");
		}
		
		[Test]
		public void BlockSpecification ()
		{
			MmlTestUtility.TestCompile ("BlockSpecification", @"
A 1	o5cde
	cdefg
B	a1	
");
		}

		[Test]
		public void SyncNoteOffWithNextAkaArpeggio ()
		{
			MmlTestUtility.TestCompile ("SyncNoteOffWithNextAkaArpeggio", "A 1 o5c&d&e");
		}
	}
}

