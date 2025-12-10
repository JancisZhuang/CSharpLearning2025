# Day 1 - 7

## **🧩 每日练习题（30分钟版）**

### **Day 1：Hello World + 开发环境**

**核心目标**：确保开发环境正常工作

1. **基础练习**：创建控制台程序，输出你的姓名和今天的日期

```jsx
// 示例答案
Console.WriteLine("我的名字是[你的名字]");
Console.WriteLine($"今天是{DateTime.Now:yyyy年MM月dd日}");
Console.ReadKey();
```

1. **进阶练习**：修改程序，当用户输入回车后再关闭窗口

```jsx
Console.WriteLine("按回车键关闭程序...");
Console.ReadLine(); // 等待用户输入
```

✅ **验证方法**：程序运行后能看到你的名字和日期，并且窗口不会自动关闭

### **Day 2：变量与基础类型**

**核心目标**：掌握基本数据类型和变量声明

1. **基础练习**：声明3个变量（整数、小数、字符串），然后输出

```jsx
int age = 25;
double height = 175.5;
string name = "张三";

Console.WriteLine($"姓名: {name}");
Console.WriteLine($"年龄: {age}岁");
Console.WriteLine($"身高: {height}cm");
Console.ReadKey();
```

1. **类型转换练习**：将字符串数字转换为整数进行计算

```jsx
string numStr = "42";
int num = Convert.ToInt32(numStr);
Console.WriteLine($"转换后加10: {num + 10}");
Console.ReadKey();
```

1. **挑战练习**：计算矩形面积（长5.5，宽3.2）

```jsx
double length = 5.5;
double width = 3.2;
double area = length * width;
Console.WriteLine($"矩形面积: {area:F2} 平方单位");
Console.ReadKey();
```

💡 **提示**：使用`$"{variable:F2}"`可以格式化小数点后2位

### **Day 3：条件判断 (if/else)**

**核心目标**：掌握条件逻辑控制

1. **基础练习**：判断数字奇偶

```jsx
Console.Write("请输入一个整数: ");
if (int.TryParse(Console.ReadLine(), out int number))
{
    if (number % 2 == 0)
        Console.WriteLine($"{number}是偶数");
    else
        Console.WriteLine($"{number}是奇数");
}
else
{
    Console.WriteLine("输入无效");
}
Console.ReadKey();
```

2.**进阶练习**：成绩等级判断（90+ = A, 80-89 = B, 70-79 = C, 其他 = D）

```jsx
Console.Write("请输入成绩(0-100): ");
if (int.TryParse(Console.ReadLine(), out int score) && score >= 0 && score <= 100)
{
    string grade = score switch
    {
        >= 90 => "A",
        >= 80 => "B",
        >= 70 => "C",
        _ => "D"
    };
    Console.WriteLine($"等级: {grade}");
}
else
{
    Console.WriteLine("成绩必须在0-100之间");
}
Console.ReadKey();
```

3.**挑战练习**：闰年判断（能被4整除但不能被100整除，除非能被400整除）

```jsx
Console.Write("请输入年份: ");
if (int.TryParse(Console.ReadLine(), out int year))
{
    bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    Console.WriteLine($"{year}年{(isLeapYear ? "是" : "不是")}闰年");
}
Console.ReadKey();
```

### **Day 4：循环基础 (for)**

**核心目标**：掌握循环结构和流程控制

1. **基础练习**：打印1-10的数字

```jsx
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.ReadKey();
```

2.**进阶练习**：打印乘法表（1-5行）

```
for (int i = 1; i <= 5; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write($"{j}x{i}={i*j}\t");
    }
    Console.WriteLine();
}
Console.ReadKey();
```

1. **挑战练习**：计算1-100的和

```
int sum = 0;
for (int i = 1; i <= 100; i++)
{
    sum += i;
}
Console.WriteLine($"1-100的和是: {sum}");
Console.ReadKey();
```

### **Day 5：多分支选择 (switch)**

**核心目标**：掌握多条件分支处理

1. **基础练习**：星期几判断

```csharp
Console.Write("请输入1-7的数字: ");
if (int.TryParse(Console.ReadLine(), out int dayNum))
{
    string dayName = dayNum switch
    {
        1 => "星期一",
        2 => "星期二",
        3 => "星期三",
        4 => "星期四",
        5 => "星期五",
        6 => "星期六",
        7 => "星期日",
        _ => "无效数字"
    };
    Console.WriteLine(dayName);
}
else
{
    Console.WriteLine("请输入有效数字");
}
Console.ReadKey();
```

1. **进阶练习**：成绩等级判断（使用switch）

```
Console.Write("请输入成绩(0-100): ");
if (int.TryParse(Console.ReadLine(), out int score))
{
    string grade = score switch
    {
        >= 90 => "A",
        >= 80 => "B",
        >= 70 => "C",
        >= 60 => "D",
        _ => "F"
    };
    Console.WriteLine($"成绩等级: {grade}");
}
Console.ReadKey();
```

3.**挑战练习**：简单计算器（加减乘除）

```
Console.Write("请输入第一个数字: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("请输入运算符(+, -, *, /): ");
char op = Console.ReadLine()[0];

Console.Write("请输入第二个数字: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double result = 0;
bool isValid = true;

switch (op)
{
    case '+': result = num1 + num2; break;
    case '-': result = num1 - num2; break;
    case '*': result = num1 * num2; break;
    case '/': 
        if (num2 == 0) 
        {
            Console.WriteLine("错误：除数不能为0");
            isValid = false;
        }
        else 
        {
            result = num1 / num2;
        }
        break;
    default:
        Console.WriteLine("错误：无效运算符");
        isValid = false;
        break;
}

if (isValid)
{
    Console.WriteLine($"{num1} {op} {num2} = {result}");
}

Console.ReadKey();
```

### **Day 6：小项目 - 简易计算器**

**核心目标**：综合运用所学知识完成完整项目

```csharp
Console.WriteLine("简易计算器");
Console.WriteLine("支持操作: +, -, *, /, %");
Console.WriteLine("输入 'exit' 退出程序");
Console.WriteLine("--------------------------------");

while (true)
{
    Console.Write("请输入表达式 (例如: 5 + 3): ");
    string input = Console.ReadLine().Trim();
    
    if (input.ToLower() == "exit")
        break;
    
    string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    
    if (parts.Length != 3)
    {
        Console.WriteLine("错误：请使用格式 '数字 运算符 数字'");
        continue;
    }
    
    if (!double.TryParse(parts[0], out double num1) || 
        !double.TryParse(parts[2], out double num2))
    {
        Console.WriteLine("错误：请输入有效的数字");
        continue;
    }
    
    char op = parts[1][0];
    double result = 0;
    bool valid = true;
    
    switch (op)
    {
        case '+': result = num1 + num2; break;
        case '-': result = num1 - num2; break;
        case '*': result = num1 * num2; break;
        case '/':
            if (num2 == 0)
            {
                Console.WriteLine("错误：除数不能为0");
                valid = false;
            }
            else
            {
                result = num1 / num2;
            }
            break;
        case '%':
            if (num2 == 0)
            {
                Console.WriteLine("错误：模数不能为0");
                valid = false;
            }
            else
            {
                result = num1 % num2;
            }
            break;
        default:
            Console.WriteLine($"错误：不支持的运算符 '{op}'");
            valid = false;
            break;
    }
    
    if (valid)
    {
        Console.WriteLine($"结果: {result}");
    }
    
    Console.WriteLine();
}

Console.WriteLine("计算器已退出。按任意键关闭...");
Console.ReadKey();
```

💡 **优化挑战**（可选）：

1. 添加历史记录功能
2. 支持括号优先级
3. 增加平方根功能

### **Day 7：复习+扩展**

**核心目标**：巩固知识并探索新概念

1. **综合练习**：猜数字游戏

```csharp
Random random = new Random();
int secretNumber = random.Next(1, 101); // 1-100
int attempts = 0;

Console.WriteLine("猜数字游戏 (1-100)");
Console.WriteLine("输入 'quit' 退出游戏");

while (true)
{
    Console.Write("请输入你的猜测: ");
    string input = Console.ReadLine().Trim();
    
    if (input.ToLower() == "quit")
        break;
    
    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("请输入有效数字");
        continue;
    }
    
    attempts++;
    
    if (guess < secretNumber)
        Console.WriteLine("太小了!");
    else if (guess > secretNumber)
        Console.WriteLine("太大了!");
    else
    {
        Console.WriteLine($"恭喜! 你猜对了! 数字是 {secretNumber}");
        Console.WriteLine($"你用了 {attempts} 次尝试");
        break;
    }
}

Console.ReadKey();
```

2.**挑战练习**：斐波那契数列（前20项）

```
Console.WriteLine("斐波那契数列前20项:");

long a = 0, b = 1;
Console.Write($"{a}, {b}");

for (int i = 2; i < 20; i++)
{
    long next = a + b;
    Console.Write($", {next}");
    a = b;
    b = next;
}

Console.ReadKey();
```