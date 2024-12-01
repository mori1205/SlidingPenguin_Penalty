using UnityEngine;

public class ParameterManager : MonoBehaviour
{
  // game parameters
  public static float sensitivity = 1.0f; //3.0
  public static int limitedTime = 20;
  public static float maximumSpeed = 8.0f; //15
  public static float acceleration = 0.050f;
  public static float friction = 0.9990f;

  // experiment parameters
  public static bool fish = true;
  public static bool gameAnimation = true;
  public static bool respawn = true;
  public static bool continuousPlay = false;
  public static float waitTimeNext = 5.0f;

  // for development
  public static bool usePhysics = true;
}
