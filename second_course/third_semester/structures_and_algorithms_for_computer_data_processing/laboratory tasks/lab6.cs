using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab6
{
	public interface IPushPop
	{
		//добавл€ет элемент в очередь или в стек
		void Push(int value);
		//возвращает последний добавленный дл€ стека (первый добавленный дл€ очереди) элемент, удал€€ его из коллекции
		int Pop();
		//возвращает последний добавленный дл€ стека (первый добавленный дл€ очереди) элемент, не удал€€ его из коллекции
		int Peek();
		//возвращает количество элементов в коллекции
		int Count { get; }
		//возвращает строку вида "{первый_элемент, второй_элемент, ... , последний_элемент}"
		string ToString();
	}

	//ќбразцовый стек, использует встроенный System.Collections.Generic.Stack<T>
	public class ReferenceStack : IPushPop
	{
		Stack<int> s = new Stack<int>();

		public void Push(int value)
		{
			s.Push(value);
		}

		public int Pop()
		{
			return s.Pop();
		}

		public int Peek()
		{
			return s.Peek();
		}

		public int Count {
			get { 
				return s.Count; 
			}
		}

		public override string ToString()
		{
			string res = "{";
			bool first = true;
			foreach (var item in s.Reverse()) {
				if (!first) {
					res += ", ";
				}
				first = false;
				res += string.Format("{0}", item);
			}
			res += "}";
			return res;
		}
	}

	//ќбразцова€ очередь, использует встроенный System.Collections.Generic.Queue<T>
	public class ReferenceQueue: IPushPop
	{
		Queue<int> q = new Queue<int>();

		public void Push(int value)
		{
			q.Enqueue(value);
		}

		public int Pop()
		{
			return q.Dequeue();
		}

		public int Peek()
		{
			return q.Peek();
		}

		public int Count {
			get {
				return q.Count;
			}
		}

		public override string ToString()
		{
			string res = "{";
			bool first = true;
			foreach (var item in q) {
				if (!first) {
					res += ", ";
				}
				first = false;
				res += string.Format("{0}", item);
			}
			res += "}";
			return res;
		}
	}

	//—тек на массиве фиксированного размера (по-умолчанию 100)
	public class FixedArrayStack : IPushPop
	{
		int[] data;
		int size = 0;

		public FixedArrayStack(int max_elements_count = 100)
		{
			data = new int[max_elements_count];
		}

		public void Push(int value)
		{
			if (size == data.Length) {
				throw new Exception("can not push to full stack");
			}
			data[size] = value;
			size++;
		}

		public int Pop()
		{
			if (size == 0) {
				throw new Exception("can not pop from empty stack");
			}
			size--;
			return data[size];
		}

		public int Count { get { return size; } }

		public int Peek()
		{
			if (size == 0) {
				throw new Exception("empty stack has no last element");
			}
			return data[size - 1];
		}

		public override string ToString()
		{
			string res = "{";
			for (int i = 0; i < size; i++) {
				if (i > 0) {
					res += ", ";
				}
				res += string.Format("{0}", data[i]);
			}
			res += "}";
			return res;
		}
	}

	public class Tests
	{
		public void Fail(string msg = "", params object[] args)
		{
			throw new Exception(string.Format(msg, args));
		}

		public void Check(bool b, string msg = "", params object[] args)
		{
			if (!b) {
				Fail(msg, args);
			}
		}

		public void MustThrow(Action a)
		{
			bool exception_thrown = false;
			try {
				a();
			}
			catch (Exception) {
				exception_thrown = true;
			}
			if (!exception_thrown) {
				Fail("exception must be thrown");
			}
		}

		public void Eq(int a, int b)
		{
			if (a != b) {
				Fail("{0} != {1}", a, b);
			}
		}

		public void Eq(string a, string b)
		{
			if (a != b) {
				Fail("\"{0}\" != \"{1}\"", a, b);
			}
		}

		public void test_empty(IPushPop c)
		{
			Eq(c.Count, 0);
			MustThrow(() => {
				int t = c.Peek();
			});
			MustThrow(() => {
				int t = c.Pop();
			});
			Eq(c.ToString(), "{}");
		}

		public void test_one_element(IPushPop c)
		{
			Eq(c.Count, 0);

			c.Push(1);
			Eq(c.Count, 1);
			Eq(c.Peek(), 1);
			Eq(c.ToString(), "{1}");
			Eq(c.Pop(), 1);
			Eq(c.Count, 0);
		}

		public void test_two_elements_stack(IPushPop c)
		{
			Eq(c.Count, 0);

			c.Push(1);
			c.Push(2);
			Eq(c.Count, 2);
			Eq(c.Peek(), 2);
			Eq(c.ToString(), "{1, 2}");
			Eq(c.Pop(), 2);
			Eq(c.Peek(), 1);
			Eq(c.Pop(), 1);
			Eq(c.Count, 0);
		}

		public void test_two_elements_queue(IPushPop c)
		{
			Eq(c.Count, 0);

			c.Push(1);
			c.Push(2);
			Eq(c.Count, 2);
			Eq(c.Peek(), 1);
			Eq(c.ToString(), "{1, 2}");
			Eq(c.Pop(), 1);
			Eq(c.Peek(), 2);
			Eq(c.Pop(), 2);
			Eq(c.Count, 0);
		}

		public void test_seq_stack(IPushPop c, int n = 7)
		{
			Eq(c.Count, 0);

			for (int i = 0; i < n; i++) {
				if (i == 3) {
					Eq(c.ToString(), "{0, 1, 4}");
				}
				Eq(c.Count, i);
				c.Push(i * i);
				Eq(c.Peek(), i * i);
			}
			if (n == 7) {
				Eq(c.ToString(), "{0, 1, 4, 9, 16, 25, 36}");
			}
			Eq(c.Count, n);
			for (int i = n - 1; i >= 0; i--) {
				Eq(c.Peek(), i * i);
				Eq(c.Pop(), i * i);
				Eq(c.Count, i);
				if (i == 3) {
					Eq(c.ToString(), "{0, 1, 4}");
				}
			}
			Eq(c.Count, 0);
		}

		public void test_seq_queue(IPushPop c, int n = 7)
		{
			Eq(c.Count, 0);

			for (int i = 0; i < n; i++) {
				if (i == 3) {
					Eq(c.ToString(), "{0, 1, 4}");
				}
				Eq(c.Count, i);
				c.Push(i * i);						
			}
			if (n == 7) {
				Eq(c.ToString(), "{0, 1, 4, 9, 16, 25, 36}");
			}
			Eq(c.Count, n);
			for (int i = 0; i < n; i++) {
				Eq(c.Peek(), i * i);
				Eq(c.Pop(), i * i);
				Eq(c.Count, n - i - 1);
				if (n - i - 1 == 3 && n == 7) {
					Eq(c.ToString(), "{16, 25, 36}");
				}
			}
			Eq(c.Count, 0);
		}

		public void test_stack(IPushPop c)
		{
			test_empty(c);
			test_one_element(c);
			test_two_elements_stack(c);
			test_seq_stack(c);
		}

		public void test_queue(IPushPop c)
		{
			test_empty(c);
			test_one_element(c);
			test_two_elements_queue(c);
			test_seq_queue(c);
		}
	}

	public class MyTests: Tests
	{
		public void go()
		{			
			test_stack(new FixedArrayStack());
			test_stack(new ReferenceStack());
			test_queue(new ReferenceQueue());
			test_seq_stack(new ReferenceStack(), 1000000);					
			test_seq_queue(new ReferenceQueue(), 1000000);	

			//сюда добавл€ете тестирование ваших классов

			Console.WriteLine("ok");
		}
	}

	public class Program
	{
		public static void Main()
		{
			new MyTests().go();
		}
	}
}
