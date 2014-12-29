namespace DynamicData
{
    /// <summary>
    /// A source list which uses the hash code to uniquely identify items
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SourceList<T> : SourceCache<T, int>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SourceList{T}"/> class.
        /// </summary>
        public SourceList()
            :base(t=>t.GetHashCode())
        {
        }
    }
}