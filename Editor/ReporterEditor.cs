using UnityEngine;
using UnityEditor ;
using UnityEditor.Callbacks;

using System.IO;
using System.Collections;



public class MyAssetModificationProcessor : UnityEditor.AssetModificationProcessor
{
    
	[InitializeOnLoad]
	public class BuildInfo
	{
		static BuildInfo ()
	    {
	        EditorApplication.update += Update;
	    }
	 
		static bool isCompiling = true ; 
	    static void Update ()
	    {
			if( !EditorApplication.isCompiling && isCompiling )
			{
	        	Debug.Log("Finish Compile");
				if( !Directory.Exists( Application.dataPath + "/StreamingAssets"))
				{
					Directory.CreateDirectory( Application.dataPath + "/StreamingAssets");
				}
				string info_path = Application.dataPath + "/StreamingAssets/build_info.txt" ;
				StreamWriter build_info = new StreamWriter( info_path );
				build_info.Write(  "Build from " + SystemInfo.deviceName + " On " + System.DateTime.Now.ToString() );
				build_info.Close();
			}
			
			isCompiling = EditorApplication.isCompiling ;
	    }
	}
}
