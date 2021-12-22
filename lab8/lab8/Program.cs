using System;
using System.Collections;
using System.Collections.Generic;

namespace lab8
{
   public class CircularLinkedList<T> : IEnumerable<T>
{
Node<T> head;
Node<T> tail;
int count;


public void Add(T data)
{
Node<T> node = new Node<T>(data);

if (head == null)
{
head = node;
tail = node;
tail.Next = head;
}
else
{
node.Next = head;
tail.Next = node;
tail = node;
}
count++;
}
public bool Remove(T data)
{
Node<T> current = head;
Node<T> previous = null;

if (IsEmpty) return false;

do
{
if (current.Data.Equals(data))
{

if (previous != null)
{

previous.Next = current.Next;


if (current == tail)
tail = previous;
}
else
{


if (count == 1)
{
head = tail = null;
}
else
{
head = current.Next;
tail.Next = current.Next;
}
}
count--;
return true;
}

previous = current;
current = current.Next;
} while (current != head);

return false;
}

public int Count { get { return count; } }
public bool IsEmpty { get { return count == 0; } }

public void Clear()
{
head = null;
tail = null;
count = 0;
}

public bool Contains(T data)
{
Node<T> current = head;
if (current == null) return false;
do
{
if (current.Data.Equals(data))
return true;
current = current.Next;
}
while (current != head);
return false;
}

IEnumerator IEnumerable.GetEnumerator()
{
return ((IEnumerable)this).GetEnumerator();
}

IEnumerator<T> IEnumerable<T>.GetEnumerator()
{
Node<T> current = head;
do
{
if (current != null)
{
yield return current.Data;
current = current.Next;
}
}
while (current != head);
}
}
public class Node<T>
{
public Node(T data)
{
Data = data;
}
public T Data { get; set; }
public Node<T> Next { get; set; }
}
public class Program { public static void Main(String[] args) { }

public String Fill(String name)
{
CircularLinkedList<long> s = new CircularLinkedList<long>();
String[] names = name.Split(' ');
String t = null;
long[] l = new long[names.Length];
for (int i = 0; i < names.Length; i++)
{
l[i] = long.Parse(names[i]);
}

for (int i = 0; i < names.Length; i++)
{
s.Add(l[i]);
}

t = "";
foreach (var y in s)
{
t = t + " " + y;
}
return t;
}

public String remove(String name, String remove)
{
CircularLinkedList<long> s = new CircularLinkedList<long>();
String[] names = name.Split(' ');
String t = null;
long[] l = new long[names.Length];
for (int i = 0; i < names.Length; i++)
{
l[i] = long.Parse(names[i]);
}

for (int i = 0; i < names.Length; i++)
{
s.Add(l[i]);
}

long re = long.Parse(remove);
s.Remove(re);
t = "";
foreach (var y in s)
{
t = t + " " + y;
}
return t;
}


public Boolean con(String name, String search)
{
CircularLinkedList<long> s = new CircularLinkedList<long>();
String[] names = name.Split(' ');
long[] l = new long[names.Length];
for (int i = 0; i < names.Length; i++)
{
l[i] = long.Parse(names[i]);
}

for (int i = 0; i < names.Length; i++)
{
s.Add(l[i]);
}

long se = long.Parse(search);
return s.Contains(se);
}

public long Pro(String name)
{
   CircularLinkedList<long> s = new CircularLinkedList<long>();
   String[] names = name.Split(' ');
   long[] l = new long[names.Length];
   for (int i = 0; i < names.Length; i++)
   {
      l[i] = long.Parse(names[i]);
   }

   for (int i = 0; i < names.Length; i++)
   {
      s.Add(l[i]);
   }

   long num = 1;
   foreach (var y in s)
   {
      if (y >= 0) num *= y;

   }

   return num;


}







}
}