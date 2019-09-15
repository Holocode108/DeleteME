using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_2019_Task1_Memo1
{
   public abstract class Building
  {
    protected Building(int x, int y, int h, string f, string sy)
    {
      xPos = x;
      yPos = y;
      health = h;
      faction = f;
      symbol = sy;
      destroyed = false;
    }
    protected int xPos;
    protected int yPos;
    protected int health;
    protected int maxHealth;
    protected string faction;
    protected string symbol;
    protected bool destroyed;

    public abstract void Destruction();
    public abstract override string ToString();

  }
}
