using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.IO;
using Ink;

public class TestCompile {

	[Test]
	public void TestCompileSimplePasses()
	{
	    var filePath = @"C:\Users\Kumo\Documents\Projects\Unity\InkUnity\Assets\story.ink";
        var outputPath = @"C:\Users\Kumo\Documents\Projects\Unity\InkUnity\Assets\story.json";
	    var compiler = new Compiler(File.ReadAllText(filePath));
	    var story = compiler.Compile();
	    var json = story.ToJsonString();
        File.WriteAllText(outputPath, json);
	}
}
