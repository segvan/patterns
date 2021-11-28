using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace patterns.library.Decorator
{
    public class CodeBuilder
    {
        private readonly StringBuilder stringBuilder = new StringBuilder();

        public static implicit operator CodeBuilder(string s)
        {
            var cb = new CodeBuilder();
            cb.stringBuilder.AppendLine(s);
            return cb;
        }

        public static CodeBuilder operator +(CodeBuilder cb, string s)
        {
            cb.stringBuilder.AppendLine(s);
            return cb;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            ((ISerializable) stringBuilder).GetObjectData(info, context);
        }

        public CodeBuilder Append(bool value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(byte value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(char value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(char value, int repeatCount)
        {
            stringBuilder.Append(value, repeatCount);
            return this;
        }

        public CodeBuilder Append(char[] value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(char[] value, int startIndex, int charCount)
        {
            stringBuilder.Append(value, startIndex, charCount);
            return this;
        }

        public CodeBuilder Append(decimal value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(double value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(short value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(int value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(long value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(object value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(ReadOnlyMemory<char> value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(ReadOnlySpan<char> value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(sbyte value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(float value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(string value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(string value, int startIndex, int count)
        {
            stringBuilder.Append(value, startIndex, count);
            return this;
        }

        public CodeBuilder Append(CodeBuilder value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(ushort value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(uint value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder Append(ulong value)
        {
            stringBuilder.Append(value);
            return this;
        }

        public CodeBuilder AppendFormat(IFormatProvider provider, string format, object arg0)
        {
            stringBuilder.AppendFormat(provider, format, arg0);
            return this;
        }

        public CodeBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1)
        {
            stringBuilder.AppendFormat(provider, format, arg0, arg1);
            return this;
        }

        public CodeBuilder AppendFormat(IFormatProvider provider, string format, object arg0, object arg1,
            object arg2)
        {
            stringBuilder.AppendFormat(provider, format, arg0, arg1, arg2);
            return this;
        }

        public CodeBuilder AppendFormat(IFormatProvider provider, string format, params object[] args)
        {
            stringBuilder.AppendFormat(provider, format, args);
            return this;
        }

        public CodeBuilder AppendFormat(string format, object arg0)
        {
            stringBuilder.AppendFormat(format, arg0);
            return this;
        }

        public CodeBuilder AppendFormat(string format, object arg0, object arg1)
        {
            stringBuilder.AppendFormat(format, arg0, arg1);
            return this;
        }

        public CodeBuilder AppendFormat(string format, object arg0, object arg1, object arg2)
        {
            stringBuilder.AppendFormat(format, arg0, arg1, arg2);
            return this;
        }

        public CodeBuilder AppendFormat(string format, params object[] args)
        {
            stringBuilder.AppendFormat(format, args);
            return this;
        }

        public CodeBuilder AppendJoin(char separator, params object[] values)
        {
            stringBuilder.AppendJoin(separator, values);
            return this;
        }

        public CodeBuilder AppendJoin(char separator, params string[] values)
        {
            stringBuilder.AppendJoin(separator, values);
            return this;
        }

        public CodeBuilder AppendJoin(string separator, params object[] values)
        {
            stringBuilder.AppendJoin(separator, values);
            return this;
        }

        public CodeBuilder AppendJoin(string separator, params string[] values)
        {
            stringBuilder.AppendJoin(separator, values);
            return this;
        }

        public CodeBuilder AppendJoin<T>(char separator, IEnumerable<T> values)
        {
            stringBuilder.AppendJoin(separator, values);
            return this;
        }

        public CodeBuilder AppendJoin<T>(string separator, IEnumerable<T> values)
        {
            stringBuilder.AppendJoin(separator, values);
            return this;
        }

        public CodeBuilder AppendLine()
        {
            stringBuilder.AppendLine();
            return this;
        }

        public CodeBuilder AppendLine(string value)
        {
            stringBuilder.AppendLine(value);
            return this;
        }

        public CodeBuilder Clear()
        {
            stringBuilder.Clear();
            return this;
        }

        public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
        {
            stringBuilder.CopyTo(sourceIndex, destination, destinationIndex, count);
        }

        public void CopyTo(int sourceIndex, Span<char> destination, int count)
        {
            stringBuilder.CopyTo(sourceIndex, destination, count);
        }

        public int EnsureCapacity(int capacity)
        {
            return stringBuilder.EnsureCapacity(capacity);
        }

        public bool Equals(ReadOnlySpan<char> span)
        {
            return stringBuilder.Equals(span);
        }

        public bool Equals(CodeBuilder sb)
        {
            return stringBuilder.Equals(sb.stringBuilder);
        }

        public StringBuilder.ChunkEnumerator GetChunks()
        {
            return stringBuilder.GetChunks();
        }

        public CodeBuilder Insert(int index, bool value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, byte value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, char value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, char[] value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, char[] value, int startIndex, int charCount)
        {
            stringBuilder.Insert(index, value, startIndex, charCount);
            return this;
        }

        public CodeBuilder Insert(int index, decimal value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, double value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, short value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, int value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, long value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, object value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, ReadOnlySpan<char> value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, sbyte value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, float value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, string value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, string value, int count)
        {
            stringBuilder.Insert(index, value, count);
            return this;
        }

        public CodeBuilder Insert(int index, ushort value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, uint value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Insert(int index, ulong value)
        {
            stringBuilder.Insert(index, value);
            return this;
        }

        public CodeBuilder Remove(int startIndex, int length)
        {
            stringBuilder.Remove(startIndex, length);
            return this;
        }

        public CodeBuilder Replace(char oldChar, char newChar)
        {
            stringBuilder.Replace(oldChar, newChar);
            return this;
        }

        public CodeBuilder Replace(char oldChar, char newChar, int startIndex, int count)
        {
            stringBuilder.Replace(oldChar, newChar, startIndex, count);
            return this;
        }

        public CodeBuilder Replace(string oldValue, string newValue)
        {
            stringBuilder.Replace(oldValue, newValue);
            return this;
        }

        public CodeBuilder Replace(string oldValue, string newValue, int startIndex, int count)
        {
            stringBuilder.Replace(oldValue, newValue, startIndex, count);
            return this;
        }

        public string ToString(int startIndex, int length)
        {
            return stringBuilder.ToString(startIndex, length);
        }

        public override string ToString()
        {
            return stringBuilder.ToString();
        }

        public int Capacity
        {
            get => stringBuilder.Capacity;
            set => stringBuilder.Capacity = value;
        }

        public char this[int index]
        {
            get => stringBuilder[index];
            set => stringBuilder[index] = value;
        }

        public int Length
        {
            get => stringBuilder.Length;
            set => stringBuilder.Length = value;
        }

        public int MaxCapacity => stringBuilder.MaxCapacity;
    }
}