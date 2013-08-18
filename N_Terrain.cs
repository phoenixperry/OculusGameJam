using UnityEngine; 
using System.Collections; 
using Utility; 

public class N_Terrain : MonoBehaviour {

	public GameObject playerGameObject;
	public Terrain referenceTerrain; 

	public int TERRAIN_BUFFER_COUNT = 50; 	
	public int spread = 1; 

	private int[] currentTerrainID; 
	private Terrain[] terrainBuffer; 
	private DoubleKeyDictionary<int, int, int> terrainUseage; 
	private DoubleKeyDictionary<int, int, TerrainData> terrainUsageData; 

	private BitArray usedTiles; 
	private BitArray touchedTiles; 
	private Vector3 referencePosition; 
	private Vector2 referenceRotation; 
	
} 