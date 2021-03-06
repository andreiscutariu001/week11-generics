﻿using System;

namespace CalculatorApp
{
    public class Calculator 
    {
        public int Add(int a, int b) 
        {
            return a + b; 
        }

        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    public class CalculatorV2
    {
        public T Add<T>(T param1, T param2) where T : class, IHaveAnAddMethod<T>
        {
            return param1.Add(param2);
        }
    }

    public interface IHaveAnAddMethod<T>
    {
        T Add(T p);
    }

    public class GenericTypeClass<T> // T poate fi folisit in toata clasa ca si tip
    {
        public void Method(T param)
        {

        }
    }

    public class GenericTypeClass2
    {
        public void Method<T>(T param) // T poate fi folisit doar in metoda curenta
        {

        }
    }
}