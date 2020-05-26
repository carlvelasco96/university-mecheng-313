class FiniteStateTable
{
  int[,] FST_X = new int[3, 3]; // 3 rows 3 cols
  int[,] FST_Y = new int[3, 2]; // 3 Events by 2 States

  struct cell_FST //groups variables of a cell (indexOfNextState and action)
  {
    public int indexOfNextState;
    public string action;
  }

  // 

  //set indexOfNextState of cell
  public void SetNextState(int stateIndex, int newIndexOfNextState)
  {
    FST_X(state, 2).indexOfNextState = newIndexOfNextState;
  }

  //set action of cell
  public void SetActions(int stateIndex, string newAction)
  {
    FST_X(state, 2).action = newAction;
  }

  //return indexOfNextState of cell
  public string GetNextState(int stateIndex)
  {
    return FST_X(state, 2).indexOfNextState;
  }

  //return action of cell
  public string GetActions(int stateIndex)
  {
    return FST_X(state, 1).action;
  }

  private void ActionW()
  {
    Console.Write("Action W");
  }

  private void ActionX()
  {
    Console.Write("Action X");
  }

  private void ActionY()
  {
    Console.Write("Action Y");
  }

  private void ActionZ()
  {
    Console.Write("Action Z");
  }

  private void ActionJ()
  {
    Console.Write("Action J");
  }

  private void ActionK()
  {
    Console.Write("Action K");
  }

  private void ActionL()
  {
    Console.Write("Action L");
  }

  static void Main()
  {

  }
}