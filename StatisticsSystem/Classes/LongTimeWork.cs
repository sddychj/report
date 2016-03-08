using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.Classes
{
  // 定义事件的参数类
  public class ValueEventArgs
      : EventArgs
  {
    public int Value { set; get; }
  }

  // 定义事件使用的委托
  public delegate void ValueChangedEventHandler(object sender, ValueEventArgs e);

  class LongTimeWork
  {
    // 定义一个事件来提示界面工作的进度
    public event ValueChangedEventHandler ValueChanged;

    // 触发事件的方法
    protected void OnValueChanged(ValueEventArgs e)
    {
      if (this.ValueChanged != null)
      {
        this.ValueChanged(this, e);
      }
    }

    public void LongTimeMethod()
    {
      for (int i = 0; i < 5; i++)
      {
        // 进行工作
        System.Threading.Thread.Sleep(1000);

        // 触发事件
        ValueEventArgs e = new ValueEventArgs() { Value = i + 1 };
        this.OnValueChanged(e);
      }
    }
  }
}
