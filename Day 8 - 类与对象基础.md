# Day 8 - 类与对象基础

## ⏱️ 时间分配

- **概念学习**：5分钟
- **代码实践**：20分钟
- **总结反思**：5分钟

---

## 📖 核心概念（5分钟）

**类 vs 对象**：

- **类（Class）**：蓝图或模板，定义对象的结构和行为
- **对象（Object）**：类的具体实例，有实际内存分配

```jsx
**1. 类（Class）是什么？**

类就像**图纸、模板、说明书**。

它本身不是真正的东西，只是告诉你某种东西应该长什么样、有什么属性、能做什么。

例子：房子的设计图是一张“类”。它描述房子有几间房、几个厕所、什么格局，但它**不是**房子。

**2. 对象（Object）是什么？**
对象是根据“类”真正造出来的**实际的东西**。
每一个对象都是类的一个“实例”。

例子：你根据设计图建出来的每一间房子，就是一个“对象”。
虽然都是从同一张设计图建出来的，但每一间实际建成的房子可以有不同的颜色、不同的家具。
```

**核心组成部分**：

- **字段（Field）**：存储数据的变量
- **属性（Property）**：控制访问字段的安全方式
- **方法（Method）**：对象能执行的操作

**访问修饰符**：

- `public`：任何地方都可访问
- `private`：仅类内部可访问（默认）

---

## 💻 代码实践（20分钟）

### 练习 1：创建基础类与对象（10分钟）

```csharp
// Student.cs
public class Student
{
    // 字段
    private string _name;
    private int _age;

    // 属性
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    // 方法
    public void DisplayInfo()
    {
        Console.WriteLine($"学生姓名: {Name}, 年龄: {Age}");
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // 创建对象
        Student student1 = new Student();

        // 设置属性
        student1.Name = "张三";
        student1.Age = 20;

        // 调用方法
        student1.DisplayInfo();

        Console.ReadKey();
    }
}

```

**操作步骤**：

1. 创建新控制台应用项目
2. 将代码复制到相应文件
3. 运行程序，观察输出
4. 尝试修改姓名和年龄，重新运行

### 练习 2：增强类设计（10分钟）

```csharp
// Car.cs
public class Car
{
    // 自动属性（简化写法）
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double FuelLevel { get; private set; } // 只读属性

    // 构造函数
    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        FuelLevel = 100.0; // 满油
    }

    // 方法
    public void Drive(double distance)
    {
        double fuelUsed = distance * 0.1; // 每公里消耗0.1升
        if (fuelUsed <= FuelLevel)
        {
            FuelLevel -= fuelUsed;
            Console.WriteLine($"行驶 {distance} 公里，剩余油量: {FuelLevel:F1}%");
        }
        else
        {
            Console.WriteLine("油量不足，无法完成行程！");
        }
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        // 使用构造函数创建对象
        Car myCar = new Car("Toyota", "Camry", 2023);

        Console.WriteLine($"我的车: {myCar.Year} {myCar.Make} {myCar.Model}");
        Console.WriteLine($"初始油量: {myCar.FuelLevel}%");

        myCar.Drive(200); // 行驶200公里
        myCar.Drive(500); // 尝试行驶500公里

        Console.ReadKey();
    }
}

关键点：每次调用方法，都会基于当前对象的状态继续变化
第一次调用：输出：剩余油量 80%
第二次调用：输出：剩余油量 30%
Drive 每调用一次，就会基于当前 FuelLevel 减一次油，输出的油量会一次比一次少。

为什么这样？

因为 myCar 是一个对象，它有自己的内部状态（属性），例如 FuelLevel。
每次调用方法 Drive：不是重新开始，是在“当前的属性值基础上”继续修改
这就是对象的特性：对象是 “活的”，它保存自己的状态，方法会改变它的状态。
```

Example: Three Cars With Independent States

```csharp
// Car.cs
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double FuelLevel { get; private set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        FuelLevel = 100.0; // full tank
    }

    public void Drive(double distance)
    {
        double fuelUsed = distance * 0.1;

        if (fuelUsed <= FuelLevel)
        {
            FuelLevel -= fuelUsed;
            Console.WriteLine($"{Make} {Model} drove {distance} km. Fuel left: {FuelLevel:F1}%");
        }
        else
        {
            Console.WriteLine($"{Make} {Model} does not have enough fuel!");
        }
    }
}

// Program.cs
class Program
{
    static void Main(string[] args)
    {
        Car carA = new Car("Toyota", "Camry", 2023);
        Car carB = new Car("Honda", "Civic", 2022);
        Car carC = new Car("Ford", "Focus", 2021);

        Console.WriteLine("Initial Fuel Levels:");
        Console.WriteLine($"Car A: {carA.FuelLevel}%");
        Console.WriteLine($"Car B: {carB.FuelLevel}%");
        Console.WriteLine($"Car C: {carC.FuelLevel}%");
        Console.WriteLine();

        // Drive different cars different distances
        carA.Drive(100);   // uses 10 fuel → goes from 100 → 90
        carB.Drive(300);   // uses 30 fuel → goes from 100 → 70
        carC.Drive(50);    // uses 5 fuel  → goes from 100 → 95

        Console.WriteLine();
        Console.WriteLine("Fuel Levels After Driving:");
        Console.WriteLine($"Car A: {carA.FuelLevel}%"); // 90%
        Console.WriteLine($"Car B: {carB.FuelLevel}%"); // 70%
        Console.WriteLine($"Car C: {carC.FuelLevel}%"); // 95%

        Console.ReadKey();
    }
}
```

**操作步骤**：

1. 创建另一个新项目
2. 实现Car类和测试代码
3. 观察构造函数和属性的使用
4. 尝试创建不同的汽车对象

---

## 📝 总结与思考（5分钟）

### 关键概念回顾

- ✅ **类**是对象的蓝图，**对象**是类的实例
- ✅ **字段**存储数据，**属性**安全地访问字段
- ✅ **构造函数**用于初始化新创建的对象
- ✅ **方法**定义对象的行为

### 编程经验积累

- 使用**自动属性**简化代码：`public string Name { get; set; }`
- 用**private set**创建只读属性
- **构造函数**名称必须与类名相同
- 使用**new关键字**创建对象实例

### 下一步学习

- 明天：方法重载与构造函数重载
- 后天：封装原则与访问修饰符深入

> 💡 专业提示：面向对象编程不是语法特性，而是一种思考问题的方式。尝试将现实世界的事物（如学生、汽车）映射为类和对象，这是掌握OOP的关键。
> 

---

## 🔁 今日复习卡

```
1. 类和对象的关系是什么？
类是图纸，对象是按照图纸创建出来的房子
2. 字段和属性有什么区别？
字段是直接存数据的变量，是真正储存值的地方，字段属于内部数据，一般不直接暴露给外部。
属性是访问字段的“方法 + 变量”包装器”。
属性让你能写出类似字段的写法，但背后真正执行的是一段代码（getter/setter）。
3. 如何创建一个新对象？
ClassName variableName = new ClassName();
4. 构造函数的作用是什么？
当你创建一个对象时，构造函数负责“初始化对象的状态”。
5. private set 属性有什么特点？
外部代码可以读取这个属性，但不能修改它；只有类内部的方法或构造函数可以修改它。
```

> ✅ 今日成就：你已经成功创建了第一个C#类！这意味着你从过程式编程迈向了面向对象编程，这是成为专业C#开发者的重要一步。
>