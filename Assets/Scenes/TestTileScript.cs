using UnityEngine;
using System.Collections;

public class TestTileScript : MonoBehaviour {
	
	private int width;
	private int height;
	
	public Transform floorTile;
	public Transform wallTile;
	
	private Color[] tileColors;
	
	public Color tileColor;
	public Color wallColor;
	
	
	public Texture2D levelTexture;
	
	//public PlayerControl player;
	
	void Start () {
		width = levelTexture.width;
		height = levelTexture.height;
		loadLevel();
		
	}
	
	
	void Update () {
		
	}
	void loadLevel()
	{
		tileColors = new Color[width * height];
		tileColors = levelTexture.GetPixels();
		
		for (int y = 0; y < height; y++)
		{
			
			for (int x = 0; x < width; x++)
			{
				
				
				if(tileColors[x+y*width] == tileColor)
				{
					Instantiate(floorTile, new Vector3(x, y), Quaternion.identity);
				}
				if(tileColors[x+y*width] == wallColor)
				{
					Instantiate(wallTile, new Vector3(x, y), Quaternion.identity);
					
				}
			}
		}
	}
}