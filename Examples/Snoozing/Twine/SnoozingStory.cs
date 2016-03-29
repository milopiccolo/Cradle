﻿/*
SnoozingStory.twee
Generated by UnityTwine on 3/29/2016 10:45:57 AM
https://github.com/daterre/UnityTwine
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityTwine;
using ITwineThread = System.Collections.Generic.IEnumerable<UnityTwine.TwineOutput>;

public partial class @SnoozingStory: TwineStory
{
	public TwineVar wait;
	public TwineVar again;
	public TwineVar click;
	public TwineVar anxiety;
	public TwineVar dream;

	Macros _macros;
	string[] _varNames;

	public override string[] VarNames
	{
		get { return _varNames; }
	}

	public partial class Macros: TwineRuntimeMacros {
	}

	public override TwineVar this[string name]
	{
		get
		{
			switch(name)
			{
				case "wait": return wait;
				case "again": return again;
				case "click": return click;
				case "anxiety": return anxiety;
				case "dream": return dream;
				default: throw new KeyNotFoundException(string.Format("There is no variable with the name '{0}'.", name));
			}
		}
		set
		{
			switch(name)
			{
				case "wait": wait = value; break;
				case "again": again = value; break;
				case "click": click = value; break;
				case "anxiety": anxiety = value; break;
				case "dream": dream = value; break;
				default: throw new KeyNotFoundException(string.Format("There is no variable with the name '{0}'.", name));
			}
		}
	}

	@SnoozingStory()
	{
		_macros = new Macros() { Story = this };
		_varNames= new string[] {
			"wait",
			"again",
			"click",
			"anxiety",
			"dream",
		};
	}
	
	void Awake() {
		base.Init();
		passage0_Init();
		passage1_Init();
		passage2_Init();
		passage3_Init();
		passage4_Init();
		passage5_Init();
		passage6_Init();
		passage7_Init();
		passage8_Init();
		passage9_Init();
		passage10_Init();
		passage11_Init();
		passage12_Init();
		passage13_Init();
		passage14_Init();
		passage15_Init();
	}

	// .............
	// #0: Start

	void passage0_Init()
	{
		this.Passages["Start"] = new TwinePassage("Start", new string[]{  }, passage0_Main);
	}

	ITwineThread passage0_Main()
	{
		yield return new TwineDisplay("alarm");
		
	}


	// .............
	// #1: alarm

	void passage1_Init()
	{
		this.Passages["alarm"] = new TwinePassage("alarm", new string[]{  }, passage1_Main);
	}

	ITwineThread passage1_Main()
	{
		wait = 1;
		yield return new TwineText(@"
		if (! again) {
			yield return new TwineText(@"
			wait = 2;
			yield return new TwineText(@"
		}
		yield return new TwineText(@"
		wait = 1.5;
		yield return new TwineText(@"
		wait = 1.5;
		yield return new TwineText(@"
		yield return new TwineLink(@"Time to get up.", @"Time to get up.", @"getUp", null);
		yield return new TwineText(@"
		yield return new TwineLink(@"snooze", @"", @"snooze", null);
		yield return new TwineText(@"
		again=true;
		
	}


	// .............
	// #2: getUp

	void passage2_Init()
	{
		this.Passages["getUp"] = new TwinePassage("getUp", new string[]{  }, passage2_Main);
	}

	ITwineThread passage2_Main()
	{
		yield return new TwineText(either("here it goes again", "out of coffee", "i can't breath", "must leave at 7:00"));
		yield return new TwineText(@"
		wait = 4;
		yield return new TwineText(@"
		
	}


	// .............
	// #3: snooze

	void passage3_Init()
	{
		this.Passages["snooze"] = new TwinePassage("snooze", new string[]{  }, passage3_Main);
	}

	ITwineThread passage3_Main()
	{
		wait = 1;
		yield return new TwineText(@"
		yield return new TwineText(either("I can't handle this right now.", "Keep my eyes closed."));
		yield return new TwineText(@"
		yield return new TwineLink(@"dream", @"Dream", @"dreaming", null);
		yield return new TwineText(@"
		yield return new TwineLink(@"anxiety", @"Anxiety", @"anxiety", null);
		yield return new TwineText(@"
		yield return new TwineLink(@"her", @"Her", @"her", null);
		
	}


	// .............
	// #4: sea

	void passage4_Init()
	{
		this.Passages["sea"] = new TwinePassage("sea", new string[]{  }, passage4_Main);
	}

	ITwineThread passage4_Main()
	{
		click = true;
		yield return new TwineText(@"
		click = false;
		yield return new TwineText(@"
		yield return new TwineLink(@"continue", @"", @"alarm", null);
		
	}


	// .............
	// #5: her

	void passage5_Init()
	{
		this.Passages["her"] = new TwinePassage("her", new string[]{  }, passage5_Main);
	}

	ITwineThread passage5_Main()
	{
		yield return new TwineText(@"when
		yield return new TwineLink(@"continue", @"continue", @"alarm", null);
		
	}


	// .............
	// #6: anxiety

	void passage6_Init()
	{
		this.Passages["anxiety"] = new TwinePassage("anxiety", new string[]{  }, passage6_Main);
	}

	ITwineThread passage6_Main()
	{
		if (anxiety == "work") {
			yield return new TwineText(@"
			anxiety = "relationship";
			yield return new TwineText(@"
		} else if (anxiety == "relationship") {
			yield return new TwineText(@"
			anxiety = "work";
			yield return new TwineText(@"
		} else {
			yield return new TwineText(@"
			anxiety = either("work", "relationship");
			yield return new TwineText(@"
		}
		yield return new TwineText(@"
		yield return new TwineDisplay(anxiety);
		
	}


	// .............
	// #7: dreaming

	void passage7_Init()
	{
		this.Passages["dreaming"] = new TwinePassage("dreaming", new string[]{  }, passage7_Main);
	}

	ITwineThread passage7_Main()
	{
		if (dream == "sea") {
			yield return new TwineText(@"
			dream = "street";
			yield return new TwineText(@"
		} else if (dream == "street") {
			yield return new TwineText(@"
			dream = "sea";
			yield return new TwineText(@"
		} else {
			yield return new TwineText(@"
			dream = either("sea", "street");
			yield return new TwineText(@"
		}
		yield return new TwineText(@"
		yield return new TwineDisplay(dream);
		
	}


	// .............
	// #8: machine3

	void passage8_Init()
	{
		this.Passages["machine3"] = new TwinePassage("machine3", new string[]{  }, passage8_Main);
	}

	ITwineThread passage8_Main()
	{
		yield return new TwineText(@"Yeah?
		yield return new TwineLink(@"continue", @"continue", @"alarm", null);
		
	}


	// .............
	// #9: relationship

	void passage9_Init()
	{
		this.Passages["relationship"] = new TwinePassage("relationship", new string[]{  }, passage9_Main);
	}

	ITwineThread passage9_Main()
	{
		yield return new TwineText(@"She knows it.
		click = true;
		yield return new TwineText(@"
		click = false;
		yield return new TwineText(@"
		yield return new TwineLink(@"continue", @"", @"alarm", null);
		
	}


	// .............
	// #10: machine2

	void passage10_Init()
	{
		this.Passages["machine2"] = new TwinePassage("machine2", new string[]{  }, passage10_Main);
	}

	ITwineThread passage10_Main()
	{
		yield return new TwineText(@"Oh, those.
		yield return new TwineLink(@"continue", @"continue", @"machine3", null);
		
	}


	// .............
	// #11: work

	void passage11_Init()
	{
		this.Passages["work"] = new TwinePassage("work", new string[]{  }, passage11_Main);
	}

	ITwineThread passage11_Main()
	{
		yield return new TwineText(@"Two days till the meeting.
		yield return new TwineLink(@"continue", @"", @"alarm", null);
		
	}


	// .............
	// #12: machine

	void passage12_Init()
	{
		this.Passages["machine"] = new TwinePassage("machine", new string[]{  }, passage12_Main);
	}

	ITwineThread passage12_Main()
	{
		yield return new TwineText(@"I can fit it.
		yield return new TwineLink(@"continue", @"continue", @"machine2", null);
		
	}


	// .............
	// #13: street

	void passage13_Init()
	{
		this.Passages["street"] = new TwinePassage("street", new string[]{  }, passage13_Main);
	}

	ITwineThread passage13_Main()
	{
		wait = 1;
		yield return new TwineText(@"
		yield return new TwineLink(@"continue", @"", @"street2", null);
		
	}


	// .............
	// #14: street3

	void passage14_Init()
	{
		this.Passages["street3"] = new TwinePassage("street3", new string[]{  }, passage14_Main);
	}

	ITwineThread passage14_Main()
	{
		wait = 1;
		yield return new TwineText(@"
		yield return new TwineLink(@"continue", @"", @"alarm", null);
		
	}


	// .............
	// #15: street2

	void passage15_Init()
	{
		this.Passages["street2"] = new TwinePassage("street2", new string[]{  }, passage15_Main);
	}

	ITwineThread passage15_Main()
	{
		wait = 1;
		yield return new TwineText(@"
		yield return new TwineLink(@"continue", @"", @"street3", null);
		
	}


}