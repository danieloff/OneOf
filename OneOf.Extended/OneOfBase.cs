using System;

namespace OneOf
{
    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException());
			return this.IsT9;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException());
			return this.IsT10;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException());
			return this.IsT11;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException());
			return this.IsT12;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException());
			return this.IsT13;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException());
			return this.IsT14;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException());
			return this.IsT15;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException());
			return this.IsT16;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException());
			return this.IsT17;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException());
			return this.IsT18;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException());
			return this.IsT19;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException());
			return this.IsT20;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException());
			return this.IsT21;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public bool IsT22 => _index == 22;

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21, t22 =>t22);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21, t22 =>t22);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException(), t22 =>t22);
			return this.IsT21;
		}

		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21> remainder)
		{
			value = this.IsT22 ? this.AsT22 : default(T22);
			remainder = this.IsT22
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>throw new InvalidOperationException());
			return this.IsT22;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                case 22: return Equals(_value22, other._value22);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                case 22: return FormatValue(typeof(T22), _value22);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                case 23: _value23 = input.AsT23; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public bool IsT22 => _index == 22;

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public bool IsT23 => _index == 23;

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21, t22 =>t22, t23 =>t23);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException(), t22 =>t22, t23 =>t23);
			return this.IsT21;
		}

		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23> remainder)
		{
			value = this.IsT22 ? this.AsT22 : default(T22);
			remainder = this.IsT22
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>throw new InvalidOperationException(), t23 =>t23);
			return this.IsT22;
		}

		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22> remainder)
		{
			value = this.IsT23 ? this.AsT23 : default(T23);
			remainder = this.IsT23
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>throw new InvalidOperationException());
			return this.IsT23;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                case 22: return Equals(_value22, other._value22);
                case 23: return Equals(_value23, other._value23);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                case 22: return FormatValue(typeof(T22), _value22);
                case 23: return FormatValue(typeof(T23), _value23);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                case 23: _value23 = input.AsT23; break;
                case 24: _value24 = input.AsT24; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public bool IsT22 => _index == 22;

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public bool IsT23 => _index == 23;

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public bool IsT24 => _index == 24;

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException(), t22 =>t22, t23 =>t23, t24 =>t24);
			return this.IsT21;
		}

		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24> remainder)
		{
			value = this.IsT22 ? this.AsT22 : default(T22);
			remainder = this.IsT22
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>throw new InvalidOperationException(), t23 =>t23, t24 =>t24);
			return this.IsT22;
		}

		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24> remainder)
		{
			value = this.IsT23 ? this.AsT23 : default(T23);
			remainder = this.IsT23
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>throw new InvalidOperationException(), t24 =>t24);
			return this.IsT23;
		}

		public bool TryPickT24(out T24 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23> remainder)
		{
			value = this.IsT24 ? this.AsT24 : default(T24);
			remainder = this.IsT24
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>throw new InvalidOperationException());
			return this.IsT24;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                case 22: return Equals(_value22, other._value22);
                case 23: return Equals(_value23, other._value23);
                case 24: return Equals(_value24, other._value24);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                case 22: return FormatValue(typeof(T22), _value22);
                case 23: return FormatValue(typeof(T23), _value23);
                case 24: return FormatValue(typeof(T24), _value24);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                case 23: _value23 = input.AsT23; break;
                case 24: _value24 = input.AsT24; break;
                case 25: _value25 = input.AsT25; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public bool IsT22 => _index == 22;

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public bool IsT23 => _index == 23;

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public bool IsT24 => _index == 24;

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public bool IsT25 => _index == 25;

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException(), t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT21;
		}

		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25> remainder)
		{
			value = this.IsT22 ? this.AsT22 : default(T22);
			remainder = this.IsT22
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>throw new InvalidOperationException(), t23 =>t23, t24 =>t24, t25 =>t25);
			return this.IsT22;
		}

		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25> remainder)
		{
			value = this.IsT23 ? this.AsT23 : default(T23);
			remainder = this.IsT23
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>throw new InvalidOperationException(), t24 =>t24, t25 =>t25);
			return this.IsT23;
		}

		public bool TryPickT24(out T24 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25> remainder)
		{
			value = this.IsT24 ? this.AsT24 : default(T24);
			remainder = this.IsT24
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>throw new InvalidOperationException(), t25 =>t25);
			return this.IsT24;
		}

		public bool TryPickT25(out T25 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24> remainder)
		{
			value = this.IsT25 ? this.AsT25 : default(T25);
			remainder = this.IsT25
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>throw new InvalidOperationException());
			return this.IsT25;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                case 22: return Equals(_value22, other._value22);
                case 23: return Equals(_value23, other._value23);
                case 24: return Equals(_value24, other._value24);
                case 25: return Equals(_value25, other._value25);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                case 22: return FormatValue(typeof(T22), _value22);
                case 23: return FormatValue(typeof(T23), _value23);
                case 24: return FormatValue(typeof(T24), _value24);
                case 25: return FormatValue(typeof(T25), _value25);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                case 23: _value23 = input.AsT23; break;
                case 24: _value24 = input.AsT24; break;
                case 25: _value25 = input.AsT25; break;
                case 26: _value26 = input.AsT26; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public bool IsT22 => _index == 22;

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public bool IsT23 => _index == 23;

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public bool IsT24 => _index == 24;

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public bool IsT25 => _index == 25;

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public bool IsT26 => _index == 26;

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException(), t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT21;
		}

		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26> remainder)
		{
			value = this.IsT22 ? this.AsT22 : default(T22);
			remainder = this.IsT22
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>throw new InvalidOperationException(), t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT22;
		}

		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26> remainder)
		{
			value = this.IsT23 ? this.AsT23 : default(T23);
			remainder = this.IsT23
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>throw new InvalidOperationException(), t24 =>t24, t25 =>t25, t26 =>t26);
			return this.IsT23;
		}

		public bool TryPickT24(out T24 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26> remainder)
		{
			value = this.IsT24 ? this.AsT24 : default(T24);
			remainder = this.IsT24
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>throw new InvalidOperationException(), t25 =>t25, t26 =>t26);
			return this.IsT24;
		}

		public bool TryPickT25(out T25 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26> remainder)
		{
			value = this.IsT25 ? this.AsT25 : default(T25);
			remainder = this.IsT25
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>throw new InvalidOperationException(), t26 =>t26);
			return this.IsT25;
		}

		public bool TryPickT26(out T26 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25> remainder)
		{
			value = this.IsT26 ? this.AsT26 : default(T26);
			remainder = this.IsT26
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>throw new InvalidOperationException());
			return this.IsT26;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                case 22: return Equals(_value22, other._value22);
                case 23: return Equals(_value23, other._value23);
                case 24: return Equals(_value24, other._value24);
                case 25: return Equals(_value25, other._value25);
                case 26: return Equals(_value26, other._value26);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                case 22: return FormatValue(typeof(T22), _value22);
                case 23: return FormatValue(typeof(T23), _value23);
                case 24: return FormatValue(typeof(T24), _value24);
                case 25: return FormatValue(typeof(T25), _value25);
                case 26: return FormatValue(typeof(T26), _value26);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                case 23: _value23 = input.AsT23; break;
                case 24: _value24 = input.AsT24; break;
                case 25: _value25 = input.AsT25; break;
                case 26: _value26 = input.AsT26; break;
                case 27: _value27 = input.AsT27; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    case 27:
                        return _value27;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public bool IsT22 => _index == 22;

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public bool IsT23 => _index == 23;

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public bool IsT24 => _index == 24;

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public bool IsT25 => _index == 25;

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public bool IsT26 => _index == 26;

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public bool IsT27 => _index == 27;

        public T27 AsT27
        {
            get
            {
                if (_index != 27)
                {
                    throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
                }
                return _value27;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            if (_index == 27 && f27 != null)
            {
                f27(_value27);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException(), t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT21;
		}

		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT22 ? this.AsT22 : default(T22);
			remainder = this.IsT22
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>throw new InvalidOperationException(), t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT22;
		}

		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27> remainder)
		{
			value = this.IsT23 ? this.AsT23 : default(T23);
			remainder = this.IsT23
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>throw new InvalidOperationException(), t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT23;
		}

		public bool TryPickT24(out T24 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27> remainder)
		{
			value = this.IsT24 ? this.AsT24 : default(T24);
			remainder = this.IsT24
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>throw new InvalidOperationException(), t25 =>t25, t26 =>t26, t27 =>t27);
			return this.IsT24;
		}

		public bool TryPickT25(out T25 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27> remainder)
		{
			value = this.IsT25 ? this.AsT25 : default(T25);
			remainder = this.IsT25
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>throw new InvalidOperationException(), t26 =>t26, t27 =>t27);
			return this.IsT25;
		}

		public bool TryPickT26(out T26 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27> remainder)
		{
			value = this.IsT26 ? this.AsT26 : default(T26);
			remainder = this.IsT26
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>throw new InvalidOperationException(), t27 =>t27);
			return this.IsT26;
		}

		public bool TryPickT27(out T27 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26> remainder)
		{
			value = this.IsT27 ? this.AsT27 : default(T27);
			remainder = this.IsT27
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>throw new InvalidOperationException());
			return this.IsT27;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                case 22: return Equals(_value22, other._value22);
                case 23: return Equals(_value23, other._value23);
                case 24: return Equals(_value24, other._value24);
                case 25: return Equals(_value25, other._value25);
                case 26: return Equals(_value26, other._value26);
                case 27: return Equals(_value27, other._value27);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                case 22: return FormatValue(typeof(T22), _value22);
                case 23: return FormatValue(typeof(T23), _value23);
                case 24: return FormatValue(typeof(T24), _value24);
                case 25: return FormatValue(typeof(T25), _value25);
                case 26: return FormatValue(typeof(T26), _value26);
                case 27: return FormatValue(typeof(T27), _value27);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    case 27:
                    hashCode = _value27?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly T28 _value28;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                case 23: _value23 = input.AsT23; break;
                case 24: _value24 = input.AsT24; break;
                case 25: _value25 = input.AsT25; break;
                case 26: _value26 = input.AsT26; break;
                case 27: _value27 = input.AsT27; break;
                case 28: _value28 = input.AsT28; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    case 27:
                        return _value27;
                    case 28:
                        return _value28;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public bool IsT22 => _index == 22;

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public bool IsT23 => _index == 23;

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public bool IsT24 => _index == 24;

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public bool IsT25 => _index == 25;

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public bool IsT26 => _index == 26;

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public bool IsT27 => _index == 27;

        public T27 AsT27
        {
            get
            {
                if (_index != 27)
                {
                    throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
                }
                return _value27;
            }
        }

        public bool IsT28 => _index == 28;

        public T28 AsT28
        {
            get
            {
                if (_index != 28)
                {
                    throw new InvalidOperationException($"Cannot return as T28 as result is T{_index}");
                }
                return _value28;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27, Action<T28> f28)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            if (_index == 27 && f27 != null)
            {
                f27(_value27);
                return;
            }
            if (_index == 28 && f28 != null)
            {
                f28(_value28);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27, Func<T28, TResult> f28)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException(), t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT21;
		}

		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT22 ? this.AsT22 : default(T22);
			remainder = this.IsT22
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>throw new InvalidOperationException(), t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT22;
		}

		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT23 ? this.AsT23 : default(T23);
			remainder = this.IsT23
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>throw new InvalidOperationException(), t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT23;
		}

		public bool TryPickT24(out T24 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28> remainder)
		{
			value = this.IsT24 ? this.AsT24 : default(T24);
			remainder = this.IsT24
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>throw new InvalidOperationException(), t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT24;
		}

		public bool TryPickT25(out T25 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28> remainder)
		{
			value = this.IsT25 ? this.AsT25 : default(T25);
			remainder = this.IsT25
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>throw new InvalidOperationException(), t26 =>t26, t27 =>t27, t28 =>t28);
			return this.IsT25;
		}

		public bool TryPickT26(out T26 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28> remainder)
		{
			value = this.IsT26 ? this.AsT26 : default(T26);
			remainder = this.IsT26
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>throw new InvalidOperationException(), t27 =>t27, t28 =>t28);
			return this.IsT26;
		}

		public bool TryPickT27(out T27 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28> remainder)
		{
			value = this.IsT27 ? this.AsT27 : default(T27);
			remainder = this.IsT27
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>throw new InvalidOperationException(), t28 =>t28);
			return this.IsT27;
		}

		public bool TryPickT28(out T28 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27> remainder)
		{
			value = this.IsT28 ? this.AsT28 : default(T28);
			remainder = this.IsT28
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>throw new InvalidOperationException());
			return this.IsT28;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                case 22: return Equals(_value22, other._value22);
                case 23: return Equals(_value23, other._value23);
                case 24: return Equals(_value24, other._value24);
                case 25: return Equals(_value25, other._value25);
                case 26: return Equals(_value26, other._value26);
                case 27: return Equals(_value27, other._value27);
                case 28: return Equals(_value28, other._value28);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                case 22: return FormatValue(typeof(T22), _value22);
                case 23: return FormatValue(typeof(T23), _value23);
                case 24: return FormatValue(typeof(T24), _value24);
                case 25: return FormatValue(typeof(T25), _value25);
                case 26: return FormatValue(typeof(T26), _value26);
                case 27: return FormatValue(typeof(T27), _value27);
                case 28: return FormatValue(typeof(T28), _value28);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    case 27:
                    hashCode = _value27?.GetHashCode() ?? 0;
                    break;
                    case 28:
                    hashCode = _value28?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly T28 _value28;
        readonly T29 _value29;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                case 23: _value23 = input.AsT23; break;
                case 24: _value24 = input.AsT24; break;
                case 25: _value25 = input.AsT25; break;
                case 26: _value26 = input.AsT26; break;
                case 27: _value27 = input.AsT27; break;
                case 28: _value28 = input.AsT28; break;
                case 29: _value29 = input.AsT29; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    case 27:
                        return _value27;
                    case 28:
                        return _value28;
                    case 29:
                        return _value29;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public bool IsT22 => _index == 22;

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public bool IsT23 => _index == 23;

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public bool IsT24 => _index == 24;

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public bool IsT25 => _index == 25;

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public bool IsT26 => _index == 26;

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public bool IsT27 => _index == 27;

        public T27 AsT27
        {
            get
            {
                if (_index != 27)
                {
                    throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
                }
                return _value27;
            }
        }

        public bool IsT28 => _index == 28;

        public T28 AsT28
        {
            get
            {
                if (_index != 28)
                {
                    throw new InvalidOperationException($"Cannot return as T28 as result is T{_index}");
                }
                return _value28;
            }
        }

        public bool IsT29 => _index == 29;

        public T29 AsT29
        {
            get
            {
                if (_index != 29)
                {
                    throw new InvalidOperationException($"Cannot return as T29 as result is T{_index}");
                }
                return _value29;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27, Action<T28> f28, Action<T29> f29)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            if (_index == 27 && f27 != null)
            {
                f27(_value27);
                return;
            }
            if (_index == 28 && f28 != null)
            {
                f28(_value28);
                return;
            }
            if (_index == 29 && f29 != null)
            {
                f29(_value29);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27, Func<T28, TResult> f28, Func<T29, TResult> f29)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            if (_index == 29 && f29 != null)
            {
                return f29(_value29);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException(), t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT21;
		}

		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT22 ? this.AsT22 : default(T22);
			remainder = this.IsT22
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>throw new InvalidOperationException(), t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT22;
		}

		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT23 ? this.AsT23 : default(T23);
			remainder = this.IsT23
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>throw new InvalidOperationException(), t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT23;
		}

		public bool TryPickT24(out T24 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT24 ? this.AsT24 : default(T24);
			remainder = this.IsT24
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>throw new InvalidOperationException(), t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT24;
		}

		public bool TryPickT25(out T25 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28, T29> remainder)
		{
			value = this.IsT25 ? this.AsT25 : default(T25);
			remainder = this.IsT25
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>throw new InvalidOperationException(), t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT25;
		}

		public bool TryPickT26(out T26 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28, T29> remainder)
		{
			value = this.IsT26 ? this.AsT26 : default(T26);
			remainder = this.IsT26
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>throw new InvalidOperationException(), t27 =>t27, t28 =>t28, t29 =>t29);
			return this.IsT26;
		}

		public bool TryPickT27(out T27 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28, T29> remainder)
		{
			value = this.IsT27 ? this.AsT27 : default(T27);
			remainder = this.IsT27
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>throw new InvalidOperationException(), t28 =>t28, t29 =>t29);
			return this.IsT27;
		}

		public bool TryPickT28(out T28 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T29> remainder)
		{
			value = this.IsT28 ? this.AsT28 : default(T28);
			remainder = this.IsT28
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>throw new InvalidOperationException(), t29 =>t29);
			return this.IsT28;
		}

		public bool TryPickT29(out T29 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28> remainder)
		{
			value = this.IsT29 ? this.AsT29 : default(T29);
			remainder = this.IsT29
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>throw new InvalidOperationException());
			return this.IsT29;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                case 22: return Equals(_value22, other._value22);
                case 23: return Equals(_value23, other._value23);
                case 24: return Equals(_value24, other._value24);
                case 25: return Equals(_value25, other._value25);
                case 26: return Equals(_value26, other._value26);
                case 27: return Equals(_value27, other._value27);
                case 28: return Equals(_value28, other._value28);
                case 29: return Equals(_value29, other._value29);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                case 22: return FormatValue(typeof(T22), _value22);
                case 23: return FormatValue(typeof(T23), _value23);
                case 24: return FormatValue(typeof(T24), _value24);
                case 25: return FormatValue(typeof(T25), _value25);
                case 26: return FormatValue(typeof(T26), _value26);
                case 27: return FormatValue(typeof(T27), _value27);
                case 28: return FormatValue(typeof(T28), _value28);
                case 29: return FormatValue(typeof(T29), _value29);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    case 27:
                    hashCode = _value27?.GetHashCode() ?? 0;
                    break;
                    case 28:
                    hashCode = _value28?.GetHashCode() ?? 0;
                    break;
                    case 29:
                    hashCode = _value29?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly T28 _value28;
        readonly T29 _value29;
        readonly T30 _value30;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                case 23: _value23 = input.AsT23; break;
                case 24: _value24 = input.AsT24; break;
                case 25: _value25 = input.AsT25; break;
                case 26: _value26 = input.AsT26; break;
                case 27: _value27 = input.AsT27; break;
                case 28: _value28 = input.AsT28; break;
                case 29: _value29 = input.AsT29; break;
                case 30: _value30 = input.AsT30; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    case 27:
                        return _value27;
                    case 28:
                        return _value28;
                    case 29:
                        return _value29;
                    case 30:
                        return _value30;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public bool IsT22 => _index == 22;

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public bool IsT23 => _index == 23;

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public bool IsT24 => _index == 24;

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public bool IsT25 => _index == 25;

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public bool IsT26 => _index == 26;

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public bool IsT27 => _index == 27;

        public T27 AsT27
        {
            get
            {
                if (_index != 27)
                {
                    throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
                }
                return _value27;
            }
        }

        public bool IsT28 => _index == 28;

        public T28 AsT28
        {
            get
            {
                if (_index != 28)
                {
                    throw new InvalidOperationException($"Cannot return as T28 as result is T{_index}");
                }
                return _value28;
            }
        }

        public bool IsT29 => _index == 29;

        public T29 AsT29
        {
            get
            {
                if (_index != 29)
                {
                    throw new InvalidOperationException($"Cannot return as T29 as result is T{_index}");
                }
                return _value29;
            }
        }

        public bool IsT30 => _index == 30;

        public T30 AsT30
        {
            get
            {
                if (_index != 30)
                {
                    throw new InvalidOperationException($"Cannot return as T30 as result is T{_index}");
                }
                return _value30;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27, Action<T28> f28, Action<T29> f29, Action<T30> f30)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            if (_index == 27 && f27 != null)
            {
                f27(_value27);
                return;
            }
            if (_index == 28 && f28 != null)
            {
                f28(_value28);
                return;
            }
            if (_index == 29 && f29 != null)
            {
                f29(_value29);
                return;
            }
            if (_index == 30 && f30 != null)
            {
                f30(_value30);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27, Func<T28, TResult> f28, Func<T29, TResult> f29, Func<T30, TResult> f30)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            if (_index == 29 && f29 != null)
            {
                return f29(_value29);
            }
            if (_index == 30 && f30 != null)
            {
                return f30(_value30);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException(), t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT21;
		}

		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT22 ? this.AsT22 : default(T22);
			remainder = this.IsT22
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>throw new InvalidOperationException(), t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT22;
		}

		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT23 ? this.AsT23 : default(T23);
			remainder = this.IsT23
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>throw new InvalidOperationException(), t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT23;
		}

		public bool TryPickT24(out T24 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT24 ? this.AsT24 : default(T24);
			remainder = this.IsT24
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>throw new InvalidOperationException(), t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT24;
		}

		public bool TryPickT25(out T25 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT25 ? this.AsT25 : default(T25);
			remainder = this.IsT25
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>throw new InvalidOperationException(), t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT25;
		}

		public bool TryPickT26(out T26 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28, T29, T30> remainder)
		{
			value = this.IsT26 ? this.AsT26 : default(T26);
			remainder = this.IsT26
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>throw new InvalidOperationException(), t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT26;
		}

		public bool TryPickT27(out T27 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28, T29, T30> remainder)
		{
			value = this.IsT27 ? this.AsT27 : default(T27);
			remainder = this.IsT27
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>throw new InvalidOperationException(), t28 =>t28, t29 =>t29, t30 =>t30);
			return this.IsT27;
		}

		public bool TryPickT28(out T28 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T29, T30> remainder)
		{
			value = this.IsT28 ? this.AsT28 : default(T28);
			remainder = this.IsT28
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>throw new InvalidOperationException(), t29 =>t29, t30 =>t30);
			return this.IsT28;
		}

		public bool TryPickT29(out T29 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T30> remainder)
		{
			value = this.IsT29 ? this.AsT29 : default(T29);
			remainder = this.IsT29
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>throw new InvalidOperationException(), t30 =>t30);
			return this.IsT29;
		}

		public bool TryPickT30(out T30 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29> remainder)
		{
			value = this.IsT30 ? this.AsT30 : default(T30);
			remainder = this.IsT30
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>throw new InvalidOperationException());
			return this.IsT30;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                case 22: return Equals(_value22, other._value22);
                case 23: return Equals(_value23, other._value23);
                case 24: return Equals(_value24, other._value24);
                case 25: return Equals(_value25, other._value25);
                case 26: return Equals(_value26, other._value26);
                case 27: return Equals(_value27, other._value27);
                case 28: return Equals(_value28, other._value28);
                case 29: return Equals(_value29, other._value29);
                case 30: return Equals(_value30, other._value30);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                case 22: return FormatValue(typeof(T22), _value22);
                case 23: return FormatValue(typeof(T23), _value23);
                case 24: return FormatValue(typeof(T24), _value24);
                case 25: return FormatValue(typeof(T25), _value25);
                case 26: return FormatValue(typeof(T26), _value26);
                case 27: return FormatValue(typeof(T27), _value27);
                case 28: return FormatValue(typeof(T28), _value28);
                case 29: return FormatValue(typeof(T29), _value29);
                case 30: return FormatValue(typeof(T30), _value30);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    case 27:
                    hashCode = _value27?.GetHashCode() ?? 0;
                    break;
                    case 28:
                    hashCode = _value28?.GetHashCode() ?? 0;
                    break;
                    case 29:
                    hashCode = _value29?.GetHashCode() ?? 0;
                    break;
                    case 30:
                    hashCode = _value30?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }

    public class OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> : IOneOf
    {
        readonly T0 _value0;
        readonly T1 _value1;
        readonly T2 _value2;
        readonly T3 _value3;
        readonly T4 _value4;
        readonly T5 _value5;
        readonly T6 _value6;
        readonly T7 _value7;
        readonly T8 _value8;
        readonly T9 _value9;
        readonly T10 _value10;
        readonly T11 _value11;
        readonly T12 _value12;
        readonly T13 _value13;
        readonly T14 _value14;
        readonly T15 _value15;
        readonly T16 _value16;
        readonly T17 _value17;
        readonly T18 _value18;
        readonly T19 _value19;
        readonly T20 _value20;
        readonly T21 _value21;
        readonly T22 _value22;
        readonly T23 _value23;
        readonly T24 _value24;
        readonly T25 _value25;
        readonly T26 _value26;
        readonly T27 _value27;
        readonly T28 _value28;
        readonly T29 _value29;
        readonly T30 _value30;
        readonly T31 _value31;
        readonly int _index;

        protected OneOfBase(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> input)
        {
            _index = input.Index;
            switch (_index)
            {
                case 0: _value0 = input.AsT0; break;
                case 1: _value1 = input.AsT1; break;
                case 2: _value2 = input.AsT2; break;
                case 3: _value3 = input.AsT3; break;
                case 4: _value4 = input.AsT4; break;
                case 5: _value5 = input.AsT5; break;
                case 6: _value6 = input.AsT6; break;
                case 7: _value7 = input.AsT7; break;
                case 8: _value8 = input.AsT8; break;
                case 9: _value9 = input.AsT9; break;
                case 10: _value10 = input.AsT10; break;
                case 11: _value11 = input.AsT11; break;
                case 12: _value12 = input.AsT12; break;
                case 13: _value13 = input.AsT13; break;
                case 14: _value14 = input.AsT14; break;
                case 15: _value15 = input.AsT15; break;
                case 16: _value16 = input.AsT16; break;
                case 17: _value17 = input.AsT17; break;
                case 18: _value18 = input.AsT18; break;
                case 19: _value19 = input.AsT19; break;
                case 20: _value20 = input.AsT20; break;
                case 21: _value21 = input.AsT21; break;
                case 22: _value22 = input.AsT22; break;
                case 23: _value23 = input.AsT23; break;
                case 24: _value24 = input.AsT24; break;
                case 25: _value25 = input.AsT25; break;
                case 26: _value26 = input.AsT26; break;
                case 27: _value27 = input.AsT27; break;
                case 28: _value28 = input.AsT28; break;
                case 29: _value29 = input.AsT29; break;
                case 30: _value30 = input.AsT30; break;
                case 31: _value31 = input.AsT31; break;
                default: throw new InvalidOperationException();
            }
        }
        
        public object Value
        {
            get
            {
                switch (_index)
                {
                    case 0:
                        return _value0;
                    case 1:
                        return _value1;
                    case 2:
                        return _value2;
                    case 3:
                        return _value3;
                    case 4:
                        return _value4;
                    case 5:
                        return _value5;
                    case 6:
                        return _value6;
                    case 7:
                        return _value7;
                    case 8:
                        return _value8;
                    case 9:
                        return _value9;
                    case 10:
                        return _value10;
                    case 11:
                        return _value11;
                    case 12:
                        return _value12;
                    case 13:
                        return _value13;
                    case 14:
                        return _value14;
                    case 15:
                        return _value15;
                    case 16:
                        return _value16;
                    case 17:
                        return _value17;
                    case 18:
                        return _value18;
                    case 19:
                        return _value19;
                    case 20:
                        return _value20;
                    case 21:
                        return _value21;
                    case 22:
                        return _value22;
                    case 23:
                        return _value23;
                    case 24:
                        return _value24;
                    case 25:
                        return _value25;
                    case 26:
                        return _value26;
                    case 27:
                        return _value27;
                    case 28:
                        return _value28;
                    case 29:
                        return _value29;
                    case 30:
                        return _value30;
                    case 31:
                        return _value31;
                    default:
                        throw new InvalidOperationException();
                }
            }
        }
        
        public int Index => _index;

        public bool IsT0 => _index == 0;

        public T0 AsT0
        {
            get
            {
                if (_index != 0)
                {
                    throw new InvalidOperationException($"Cannot return as T0 as result is T{_index}");
                }
                return _value0;
            }
        }

        public bool IsT1 => _index == 1;

        public T1 AsT1
        {
            get
            {
                if (_index != 1)
                {
                    throw new InvalidOperationException($"Cannot return as T1 as result is T{_index}");
                }
                return _value1;
            }
        }

        public bool IsT2 => _index == 2;

        public T2 AsT2
        {
            get
            {
                if (_index != 2)
                {
                    throw new InvalidOperationException($"Cannot return as T2 as result is T{_index}");
                }
                return _value2;
            }
        }

        public bool IsT3 => _index == 3;

        public T3 AsT3
        {
            get
            {
                if (_index != 3)
                {
                    throw new InvalidOperationException($"Cannot return as T3 as result is T{_index}");
                }
                return _value3;
            }
        }

        public bool IsT4 => _index == 4;

        public T4 AsT4
        {
            get
            {
                if (_index != 4)
                {
                    throw new InvalidOperationException($"Cannot return as T4 as result is T{_index}");
                }
                return _value4;
            }
        }

        public bool IsT5 => _index == 5;

        public T5 AsT5
        {
            get
            {
                if (_index != 5)
                {
                    throw new InvalidOperationException($"Cannot return as T5 as result is T{_index}");
                }
                return _value5;
            }
        }

        public bool IsT6 => _index == 6;

        public T6 AsT6
        {
            get
            {
                if (_index != 6)
                {
                    throw new InvalidOperationException($"Cannot return as T6 as result is T{_index}");
                }
                return _value6;
            }
        }

        public bool IsT7 => _index == 7;

        public T7 AsT7
        {
            get
            {
                if (_index != 7)
                {
                    throw new InvalidOperationException($"Cannot return as T7 as result is T{_index}");
                }
                return _value7;
            }
        }

        public bool IsT8 => _index == 8;

        public T8 AsT8
        {
            get
            {
                if (_index != 8)
                {
                    throw new InvalidOperationException($"Cannot return as T8 as result is T{_index}");
                }
                return _value8;
            }
        }

        public bool IsT9 => _index == 9;

        public T9 AsT9
        {
            get
            {
                if (_index != 9)
                {
                    throw new InvalidOperationException($"Cannot return as T9 as result is T{_index}");
                }
                return _value9;
            }
        }

        public bool IsT10 => _index == 10;

        public T10 AsT10
        {
            get
            {
                if (_index != 10)
                {
                    throw new InvalidOperationException($"Cannot return as T10 as result is T{_index}");
                }
                return _value10;
            }
        }

        public bool IsT11 => _index == 11;

        public T11 AsT11
        {
            get
            {
                if (_index != 11)
                {
                    throw new InvalidOperationException($"Cannot return as T11 as result is T{_index}");
                }
                return _value11;
            }
        }

        public bool IsT12 => _index == 12;

        public T12 AsT12
        {
            get
            {
                if (_index != 12)
                {
                    throw new InvalidOperationException($"Cannot return as T12 as result is T{_index}");
                }
                return _value12;
            }
        }

        public bool IsT13 => _index == 13;

        public T13 AsT13
        {
            get
            {
                if (_index != 13)
                {
                    throw new InvalidOperationException($"Cannot return as T13 as result is T{_index}");
                }
                return _value13;
            }
        }

        public bool IsT14 => _index == 14;

        public T14 AsT14
        {
            get
            {
                if (_index != 14)
                {
                    throw new InvalidOperationException($"Cannot return as T14 as result is T{_index}");
                }
                return _value14;
            }
        }

        public bool IsT15 => _index == 15;

        public T15 AsT15
        {
            get
            {
                if (_index != 15)
                {
                    throw new InvalidOperationException($"Cannot return as T15 as result is T{_index}");
                }
                return _value15;
            }
        }

        public bool IsT16 => _index == 16;

        public T16 AsT16
        {
            get
            {
                if (_index != 16)
                {
                    throw new InvalidOperationException($"Cannot return as T16 as result is T{_index}");
                }
                return _value16;
            }
        }

        public bool IsT17 => _index == 17;

        public T17 AsT17
        {
            get
            {
                if (_index != 17)
                {
                    throw new InvalidOperationException($"Cannot return as T17 as result is T{_index}");
                }
                return _value17;
            }
        }

        public bool IsT18 => _index == 18;

        public T18 AsT18
        {
            get
            {
                if (_index != 18)
                {
                    throw new InvalidOperationException($"Cannot return as T18 as result is T{_index}");
                }
                return _value18;
            }
        }

        public bool IsT19 => _index == 19;

        public T19 AsT19
        {
            get
            {
                if (_index != 19)
                {
                    throw new InvalidOperationException($"Cannot return as T19 as result is T{_index}");
                }
                return _value19;
            }
        }

        public bool IsT20 => _index == 20;

        public T20 AsT20
        {
            get
            {
                if (_index != 20)
                {
                    throw new InvalidOperationException($"Cannot return as T20 as result is T{_index}");
                }
                return _value20;
            }
        }

        public bool IsT21 => _index == 21;

        public T21 AsT21
        {
            get
            {
                if (_index != 21)
                {
                    throw new InvalidOperationException($"Cannot return as T21 as result is T{_index}");
                }
                return _value21;
            }
        }

        public bool IsT22 => _index == 22;

        public T22 AsT22
        {
            get
            {
                if (_index != 22)
                {
                    throw new InvalidOperationException($"Cannot return as T22 as result is T{_index}");
                }
                return _value22;
            }
        }

        public bool IsT23 => _index == 23;

        public T23 AsT23
        {
            get
            {
                if (_index != 23)
                {
                    throw new InvalidOperationException($"Cannot return as T23 as result is T{_index}");
                }
                return _value23;
            }
        }

        public bool IsT24 => _index == 24;

        public T24 AsT24
        {
            get
            {
                if (_index != 24)
                {
                    throw new InvalidOperationException($"Cannot return as T24 as result is T{_index}");
                }
                return _value24;
            }
        }

        public bool IsT25 => _index == 25;

        public T25 AsT25
        {
            get
            {
                if (_index != 25)
                {
                    throw new InvalidOperationException($"Cannot return as T25 as result is T{_index}");
                }
                return _value25;
            }
        }

        public bool IsT26 => _index == 26;

        public T26 AsT26
        {
            get
            {
                if (_index != 26)
                {
                    throw new InvalidOperationException($"Cannot return as T26 as result is T{_index}");
                }
                return _value26;
            }
        }

        public bool IsT27 => _index == 27;

        public T27 AsT27
        {
            get
            {
                if (_index != 27)
                {
                    throw new InvalidOperationException($"Cannot return as T27 as result is T{_index}");
                }
                return _value27;
            }
        }

        public bool IsT28 => _index == 28;

        public T28 AsT28
        {
            get
            {
                if (_index != 28)
                {
                    throw new InvalidOperationException($"Cannot return as T28 as result is T{_index}");
                }
                return _value28;
            }
        }

        public bool IsT29 => _index == 29;

        public T29 AsT29
        {
            get
            {
                if (_index != 29)
                {
                    throw new InvalidOperationException($"Cannot return as T29 as result is T{_index}");
                }
                return _value29;
            }
        }

        public bool IsT30 => _index == 30;

        public T30 AsT30
        {
            get
            {
                if (_index != 30)
                {
                    throw new InvalidOperationException($"Cannot return as T30 as result is T{_index}");
                }
                return _value30;
            }
        }

        public bool IsT31 => _index == 31;

        public T31 AsT31
        {
            get
            {
                if (_index != 31)
                {
                    throw new InvalidOperationException($"Cannot return as T31 as result is T{_index}");
                }
                return _value31;
            }
        }

        public void Switch(Action<T0> f0, Action<T1> f1, Action<T2> f2, Action<T3> f3, Action<T4> f4, Action<T5> f5, Action<T6> f6, Action<T7> f7, Action<T8> f8, Action<T9> f9, Action<T10> f10, Action<T11> f11, Action<T12> f12, Action<T13> f13, Action<T14> f14, Action<T15> f15, Action<T16> f16, Action<T17> f17, Action<T18> f18, Action<T19> f19, Action<T20> f20, Action<T21> f21, Action<T22> f22, Action<T23> f23, Action<T24> f24, Action<T25> f25, Action<T26> f26, Action<T27> f27, Action<T28> f28, Action<T29> f29, Action<T30> f30, Action<T31> f31)
        {
            if (_index == 0 && f0 != null)
            {
                f0(_value0);
                return;
            }
            if (_index == 1 && f1 != null)
            {
                f1(_value1);
                return;
            }
            if (_index == 2 && f2 != null)
            {
                f2(_value2);
                return;
            }
            if (_index == 3 && f3 != null)
            {
                f3(_value3);
                return;
            }
            if (_index == 4 && f4 != null)
            {
                f4(_value4);
                return;
            }
            if (_index == 5 && f5 != null)
            {
                f5(_value5);
                return;
            }
            if (_index == 6 && f6 != null)
            {
                f6(_value6);
                return;
            }
            if (_index == 7 && f7 != null)
            {
                f7(_value7);
                return;
            }
            if (_index == 8 && f8 != null)
            {
                f8(_value8);
                return;
            }
            if (_index == 9 && f9 != null)
            {
                f9(_value9);
                return;
            }
            if (_index == 10 && f10 != null)
            {
                f10(_value10);
                return;
            }
            if (_index == 11 && f11 != null)
            {
                f11(_value11);
                return;
            }
            if (_index == 12 && f12 != null)
            {
                f12(_value12);
                return;
            }
            if (_index == 13 && f13 != null)
            {
                f13(_value13);
                return;
            }
            if (_index == 14 && f14 != null)
            {
                f14(_value14);
                return;
            }
            if (_index == 15 && f15 != null)
            {
                f15(_value15);
                return;
            }
            if (_index == 16 && f16 != null)
            {
                f16(_value16);
                return;
            }
            if (_index == 17 && f17 != null)
            {
                f17(_value17);
                return;
            }
            if (_index == 18 && f18 != null)
            {
                f18(_value18);
                return;
            }
            if (_index == 19 && f19 != null)
            {
                f19(_value19);
                return;
            }
            if (_index == 20 && f20 != null)
            {
                f20(_value20);
                return;
            }
            if (_index == 21 && f21 != null)
            {
                f21(_value21);
                return;
            }
            if (_index == 22 && f22 != null)
            {
                f22(_value22);
                return;
            }
            if (_index == 23 && f23 != null)
            {
                f23(_value23);
                return;
            }
            if (_index == 24 && f24 != null)
            {
                f24(_value24);
                return;
            }
            if (_index == 25 && f25 != null)
            {
                f25(_value25);
                return;
            }
            if (_index == 26 && f26 != null)
            {
                f26(_value26);
                return;
            }
            if (_index == 27 && f27 != null)
            {
                f27(_value27);
                return;
            }
            if (_index == 28 && f28 != null)
            {
                f28(_value28);
                return;
            }
            if (_index == 29 && f29 != null)
            {
                f29(_value29);
                return;
            }
            if (_index == 30 && f30 != null)
            {
                f30(_value30);
                return;
            }
            if (_index == 31 && f31 != null)
            {
                f31(_value31);
                return;
            }
            throw new InvalidOperationException();
        }

        public TResult Match<TResult>(Func<T0, TResult> f0, Func<T1, TResult> f1, Func<T2, TResult> f2, Func<T3, TResult> f3, Func<T4, TResult> f4, Func<T5, TResult> f5, Func<T6, TResult> f6, Func<T7, TResult> f7, Func<T8, TResult> f8, Func<T9, TResult> f9, Func<T10, TResult> f10, Func<T11, TResult> f11, Func<T12, TResult> f12, Func<T13, TResult> f13, Func<T14, TResult> f14, Func<T15, TResult> f15, Func<T16, TResult> f16, Func<T17, TResult> f17, Func<T18, TResult> f18, Func<T19, TResult> f19, Func<T20, TResult> f20, Func<T21, TResult> f21, Func<T22, TResult> f22, Func<T23, TResult> f23, Func<T24, TResult> f24, Func<T25, TResult> f25, Func<T26, TResult> f26, Func<T27, TResult> f27, Func<T28, TResult> f28, Func<T29, TResult> f29, Func<T30, TResult> f30, Func<T31, TResult> f31)
        {
            if (_index == 0 && f0 != null)
            {
                return f0(_value0);
            }
            if (_index == 1 && f1 != null)
            {
                return f1(_value1);
            }
            if (_index == 2 && f2 != null)
            {
                return f2(_value2);
            }
            if (_index == 3 && f3 != null)
            {
                return f3(_value3);
            }
            if (_index == 4 && f4 != null)
            {
                return f4(_value4);
            }
            if (_index == 5 && f5 != null)
            {
                return f5(_value5);
            }
            if (_index == 6 && f6 != null)
            {
                return f6(_value6);
            }
            if (_index == 7 && f7 != null)
            {
                return f7(_value7);
            }
            if (_index == 8 && f8 != null)
            {
                return f8(_value8);
            }
            if (_index == 9 && f9 != null)
            {
                return f9(_value9);
            }
            if (_index == 10 && f10 != null)
            {
                return f10(_value10);
            }
            if (_index == 11 && f11 != null)
            {
                return f11(_value11);
            }
            if (_index == 12 && f12 != null)
            {
                return f12(_value12);
            }
            if (_index == 13 && f13 != null)
            {
                return f13(_value13);
            }
            if (_index == 14 && f14 != null)
            {
                return f14(_value14);
            }
            if (_index == 15 && f15 != null)
            {
                return f15(_value15);
            }
            if (_index == 16 && f16 != null)
            {
                return f16(_value16);
            }
            if (_index == 17 && f17 != null)
            {
                return f17(_value17);
            }
            if (_index == 18 && f18 != null)
            {
                return f18(_value18);
            }
            if (_index == 19 && f19 != null)
            {
                return f19(_value19);
            }
            if (_index == 20 && f20 != null)
            {
                return f20(_value20);
            }
            if (_index == 21 && f21 != null)
            {
                return f21(_value21);
            }
            if (_index == 22 && f22 != null)
            {
                return f22(_value22);
            }
            if (_index == 23 && f23 != null)
            {
                return f23(_value23);
            }
            if (_index == 24 && f24 != null)
            {
                return f24(_value24);
            }
            if (_index == 25 && f25 != null)
            {
                return f25(_value25);
            }
            if (_index == 26 && f26 != null)
            {
                return f26(_value26);
            }
            if (_index == 27 && f27 != null)
            {
                return f27(_value27);
            }
            if (_index == 28 && f28 != null)
            {
                return f28(_value28);
            }
            if (_index == 29 && f29 != null)
            {
                return f29(_value29);
            }
            if (_index == 30 && f30 != null)
            {
                return f30(_value30);
            }
            if (_index == 31 && f31 != null)
            {
                return f31(_value31);
            }
            throw new InvalidOperationException();
        }

		public bool TryPickT0(out T0 value, out OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT0 ? this.AsT0 : default(T0);
			remainder = this.IsT0
				? default(OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>throw new InvalidOperationException(), t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT0;
		}

		public bool TryPickT1(out T1 value, out OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT1 ? this.AsT1 : default(T1);
			remainder = this.IsT1
				? default(OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>throw new InvalidOperationException(), t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT1;
		}

		public bool TryPickT2(out T2 value, out OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT2 ? this.AsT2 : default(T2);
			remainder = this.IsT2
				? default(OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>throw new InvalidOperationException(), t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT2;
		}

		public bool TryPickT3(out T3 value, out OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT3 ? this.AsT3 : default(T3);
			remainder = this.IsT3
				? default(OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>throw new InvalidOperationException(), t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT3;
		}

		public bool TryPickT4(out T4 value, out OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT4 ? this.AsT4 : default(T4);
			remainder = this.IsT4
				? default(OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>throw new InvalidOperationException(), t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT4;
		}

		public bool TryPickT5(out T5 value, out OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT5 ? this.AsT5 : default(T5);
			remainder = this.IsT5
				? default(OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>throw new InvalidOperationException(), t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT5;
		}

		public bool TryPickT6(out T6 value, out OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT6 ? this.AsT6 : default(T6);
			remainder = this.IsT6
				? default(OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>throw new InvalidOperationException(), t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT6;
		}

		public bool TryPickT7(out T7 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT7 ? this.AsT7 : default(T7);
			remainder = this.IsT7
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>throw new InvalidOperationException(), t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT7;
		}

		public bool TryPickT8(out T8 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT8 ? this.AsT8 : default(T8);
			remainder = this.IsT8
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>throw new InvalidOperationException(), t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT8;
		}

		public bool TryPickT9(out T9 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT9 ? this.AsT9 : default(T9);
			remainder = this.IsT9
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>throw new InvalidOperationException(), t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT9;
		}

		public bool TryPickT10(out T10 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT10 ? this.AsT10 : default(T10);
			remainder = this.IsT10
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>throw new InvalidOperationException(), t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT10;
		}

		public bool TryPickT11(out T11 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT11 ? this.AsT11 : default(T11);
			remainder = this.IsT11
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>throw new InvalidOperationException(), t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT11;
		}

		public bool TryPickT12(out T12 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT12 ? this.AsT12 : default(T12);
			remainder = this.IsT12
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>throw new InvalidOperationException(), t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT12;
		}

		public bool TryPickT13(out T13 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT13 ? this.AsT13 : default(T13);
			remainder = this.IsT13
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>throw new InvalidOperationException(), t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT13;
		}

		public bool TryPickT14(out T14 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT14 ? this.AsT14 : default(T14);
			remainder = this.IsT14
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>throw new InvalidOperationException(), t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT14;
		}

		public bool TryPickT15(out T15 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT15 ? this.AsT15 : default(T15);
			remainder = this.IsT15
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>throw new InvalidOperationException(), t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT15;
		}

		public bool TryPickT16(out T16 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT16 ? this.AsT16 : default(T16);
			remainder = this.IsT16
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>throw new InvalidOperationException(), t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT16;
		}

		public bool TryPickT17(out T17 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT17 ? this.AsT17 : default(T17);
			remainder = this.IsT17
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>throw new InvalidOperationException(), t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT17;
		}

		public bool TryPickT18(out T18 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT18 ? this.AsT18 : default(T18);
			remainder = this.IsT18
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>throw new InvalidOperationException(), t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT18;
		}

		public bool TryPickT19(out T19 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT19 ? this.AsT19 : default(T19);
			remainder = this.IsT19
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>throw new InvalidOperationException(), t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT19;
		}

		public bool TryPickT20(out T20 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT20 ? this.AsT20 : default(T20);
			remainder = this.IsT20
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>throw new InvalidOperationException(), t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT20;
		}

		public bool TryPickT21(out T21 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT21 ? this.AsT21 : default(T21);
			remainder = this.IsT21
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>throw new InvalidOperationException(), t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT21;
		}

		public bool TryPickT22(out T22 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT22 ? this.AsT22 : default(T22);
			remainder = this.IsT22
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T23, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>throw new InvalidOperationException(), t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT22;
		}

		public bool TryPickT23(out T23 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT23 ? this.AsT23 : default(T23);
			remainder = this.IsT23
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T24, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>throw new InvalidOperationException(), t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT23;
		}

		public bool TryPickT24(out T24 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT24 ? this.AsT24 : default(T24);
			remainder = this.IsT24
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T25, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>throw new InvalidOperationException(), t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT24;
		}

		public bool TryPickT25(out T25 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT25 ? this.AsT25 : default(T25);
			remainder = this.IsT25
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T26, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>throw new InvalidOperationException(), t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT25;
		}

		public bool TryPickT26(out T26 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28, T29, T30, T31> remainder)
		{
			value = this.IsT26 ? this.AsT26 : default(T26);
			remainder = this.IsT26
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T27, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>throw new InvalidOperationException(), t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT26;
		}

		public bool TryPickT27(out T27 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28, T29, T30, T31> remainder)
		{
			value = this.IsT27 ? this.AsT27 : default(T27);
			remainder = this.IsT27
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T28, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>throw new InvalidOperationException(), t28 =>t28, t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT27;
		}

		public bool TryPickT28(out T28 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T29, T30, T31> remainder)
		{
			value = this.IsT28 ? this.AsT28 : default(T28);
			remainder = this.IsT28
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T29, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T29, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>throw new InvalidOperationException(), t29 =>t29, t30 =>t30, t31 =>t31);
			return this.IsT28;
		}

		public bool TryPickT29(out T29 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T30, T31> remainder)
		{
			value = this.IsT29 ? this.AsT29 : default(T29);
			remainder = this.IsT29
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T30, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T30, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>throw new InvalidOperationException(), t30 =>t30, t31 =>t31);
			return this.IsT29;
		}

		public bool TryPickT30(out T30 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T31> remainder)
		{
			value = this.IsT30 ? this.AsT30 : default(T30);
			remainder = this.IsT30
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T31>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T31>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>throw new InvalidOperationException(), t31 =>t31);
			return this.IsT30;
		}

		public bool TryPickT31(out T31 value, out OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30> remainder)
		{
			value = this.IsT31 ? this.AsT31 : default(T31);
			remainder = this.IsT31
				? default(OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>) 
				: this.Match<OneOf<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30>>(t0 =>t0, t1 =>t1, t2 =>t2, t3 =>t3, t4 =>t4, t5 =>t5, t6 =>t6, t7 =>t7, t8 =>t8, t9 =>t9, t10 =>t10, t11 =>t11, t12 =>t12, t13 =>t13, t14 =>t14, t15 =>t15, t16 =>t16, t17 =>t17, t18 =>t18, t19 =>t19, t20 =>t20, t21 =>t21, t22 =>t22, t23 =>t23, t24 =>t24, t25 =>t25, t26 =>t26, t27 =>t27, t28 =>t28, t29 =>t29, t30 =>t30, t31 =>throw new InvalidOperationException());
			return this.IsT31;
		}

        bool Equals(OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31> other)
        {
            if (_index != other._index)
            {
                return false;
            }
            switch (_index)
            {
                case 0: return Equals(_value0, other._value0);
                case 1: return Equals(_value1, other._value1);
                case 2: return Equals(_value2, other._value2);
                case 3: return Equals(_value3, other._value3);
                case 4: return Equals(_value4, other._value4);
                case 5: return Equals(_value5, other._value5);
                case 6: return Equals(_value6, other._value6);
                case 7: return Equals(_value7, other._value7);
                case 8: return Equals(_value8, other._value8);
                case 9: return Equals(_value9, other._value9);
                case 10: return Equals(_value10, other._value10);
                case 11: return Equals(_value11, other._value11);
                case 12: return Equals(_value12, other._value12);
                case 13: return Equals(_value13, other._value13);
                case 14: return Equals(_value14, other._value14);
                case 15: return Equals(_value15, other._value15);
                case 16: return Equals(_value16, other._value16);
                case 17: return Equals(_value17, other._value17);
                case 18: return Equals(_value18, other._value18);
                case 19: return Equals(_value19, other._value19);
                case 20: return Equals(_value20, other._value20);
                case 21: return Equals(_value21, other._value21);
                case 22: return Equals(_value22, other._value22);
                case 23: return Equals(_value23, other._value23);
                case 24: return Equals(_value24, other._value24);
                case 25: return Equals(_value25, other._value25);
                case 26: return Equals(_value26, other._value26);
                case 27: return Equals(_value27, other._value27);
                case 28: return Equals(_value28, other._value28);
                case 29: return Equals(_value29, other._value29);
                case 30: return Equals(_value30, other._value30);
                case 31: return Equals(_value31, other._value31);
                default: return false;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            

            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as OneOfBase<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, T17, T18, T19, T20, T21, T22, T23, T24, T25, T26, T27, T28, T29, T30, T31>;
            return other != null && Equals(other);
        }

        public override string ToString()
        {
            string FormatValue<T>(Type type, T value) => object.ReferenceEquals(this, value) ? base.ToString() : $"{type.FullName}: {value?.ToString()}";
            switch(_index) {
                case 0: return FormatValue(typeof(T0), _value0);
                case 1: return FormatValue(typeof(T1), _value1);
                case 2: return FormatValue(typeof(T2), _value2);
                case 3: return FormatValue(typeof(T3), _value3);
                case 4: return FormatValue(typeof(T4), _value4);
                case 5: return FormatValue(typeof(T5), _value5);
                case 6: return FormatValue(typeof(T6), _value6);
                case 7: return FormatValue(typeof(T7), _value7);
                case 8: return FormatValue(typeof(T8), _value8);
                case 9: return FormatValue(typeof(T9), _value9);
                case 10: return FormatValue(typeof(T10), _value10);
                case 11: return FormatValue(typeof(T11), _value11);
                case 12: return FormatValue(typeof(T12), _value12);
                case 13: return FormatValue(typeof(T13), _value13);
                case 14: return FormatValue(typeof(T14), _value14);
                case 15: return FormatValue(typeof(T15), _value15);
                case 16: return FormatValue(typeof(T16), _value16);
                case 17: return FormatValue(typeof(T17), _value17);
                case 18: return FormatValue(typeof(T18), _value18);
                case 19: return FormatValue(typeof(T19), _value19);
                case 20: return FormatValue(typeof(T20), _value20);
                case 21: return FormatValue(typeof(T21), _value21);
                case 22: return FormatValue(typeof(T22), _value22);
                case 23: return FormatValue(typeof(T23), _value23);
                case 24: return FormatValue(typeof(T24), _value24);
                case 25: return FormatValue(typeof(T25), _value25);
                case 26: return FormatValue(typeof(T26), _value26);
                case 27: return FormatValue(typeof(T27), _value27);
                case 28: return FormatValue(typeof(T28), _value28);
                case 29: return FormatValue(typeof(T29), _value29);
                case 30: return FormatValue(typeof(T30), _value30);
                case 31: return FormatValue(typeof(T31), _value31);
                default: throw new InvalidOperationException("Unexpected index, which indicates a problem in the OneOf codegen.");
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode;
                switch (_index)
                {
                    case 0:
                    hashCode = _value0?.GetHashCode() ?? 0;
                    break;
                    case 1:
                    hashCode = _value1?.GetHashCode() ?? 0;
                    break;
                    case 2:
                    hashCode = _value2?.GetHashCode() ?? 0;
                    break;
                    case 3:
                    hashCode = _value3?.GetHashCode() ?? 0;
                    break;
                    case 4:
                    hashCode = _value4?.GetHashCode() ?? 0;
                    break;
                    case 5:
                    hashCode = _value5?.GetHashCode() ?? 0;
                    break;
                    case 6:
                    hashCode = _value6?.GetHashCode() ?? 0;
                    break;
                    case 7:
                    hashCode = _value7?.GetHashCode() ?? 0;
                    break;
                    case 8:
                    hashCode = _value8?.GetHashCode() ?? 0;
                    break;
                    case 9:
                    hashCode = _value9?.GetHashCode() ?? 0;
                    break;
                    case 10:
                    hashCode = _value10?.GetHashCode() ?? 0;
                    break;
                    case 11:
                    hashCode = _value11?.GetHashCode() ?? 0;
                    break;
                    case 12:
                    hashCode = _value12?.GetHashCode() ?? 0;
                    break;
                    case 13:
                    hashCode = _value13?.GetHashCode() ?? 0;
                    break;
                    case 14:
                    hashCode = _value14?.GetHashCode() ?? 0;
                    break;
                    case 15:
                    hashCode = _value15?.GetHashCode() ?? 0;
                    break;
                    case 16:
                    hashCode = _value16?.GetHashCode() ?? 0;
                    break;
                    case 17:
                    hashCode = _value17?.GetHashCode() ?? 0;
                    break;
                    case 18:
                    hashCode = _value18?.GetHashCode() ?? 0;
                    break;
                    case 19:
                    hashCode = _value19?.GetHashCode() ?? 0;
                    break;
                    case 20:
                    hashCode = _value20?.GetHashCode() ?? 0;
                    break;
                    case 21:
                    hashCode = _value21?.GetHashCode() ?? 0;
                    break;
                    case 22:
                    hashCode = _value22?.GetHashCode() ?? 0;
                    break;
                    case 23:
                    hashCode = _value23?.GetHashCode() ?? 0;
                    break;
                    case 24:
                    hashCode = _value24?.GetHashCode() ?? 0;
                    break;
                    case 25:
                    hashCode = _value25?.GetHashCode() ?? 0;
                    break;
                    case 26:
                    hashCode = _value26?.GetHashCode() ?? 0;
                    break;
                    case 27:
                    hashCode = _value27?.GetHashCode() ?? 0;
                    break;
                    case 28:
                    hashCode = _value28?.GetHashCode() ?? 0;
                    break;
                    case 29:
                    hashCode = _value29?.GetHashCode() ?? 0;
                    break;
                    case 30:
                    hashCode = _value30?.GetHashCode() ?? 0;
                    break;
                    case 31:
                    hashCode = _value31?.GetHashCode() ?? 0;
                    break;
                    default:
                        hashCode = 0;
                        break;
                }
                return (hashCode*397) ^ _index;
            }
        }
    }
}
