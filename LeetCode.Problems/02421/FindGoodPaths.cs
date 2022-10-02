namespace LeetCode.Problems;

public class FindGoodPaths {

     public int NumberOfGoodPaths(int[] vals, int[][] edges) {
        var uf = new UnionFind(vals.Length);

        Dictionary<int, List<int>> v = new (), c = new ();
        for (int i = 0; i < vals.Length; i++)
        {
            if (!v.ContainsKey(vals[i])) v[vals[i]] = new ();
            v[vals[i]].Add(i);
        }

        for (int i = 0; i < vals.Length; i++) c[i] = new ();
        for (int i = 0; i < edges.Length; i++)
        {
            c[edges[i][0]].Add(edges[i][1]);
            c[edges[i][1]].Add(edges[i][0]);
        }

        int ans = vals.Length;
        foreach (var (cv, vn) in v.OrderBy(x => x.Key))
        {
            foreach (var n in vn)
            {
                foreach (var cn in c[n].Where(x => vals[x] <= cv))
                    uf.Union(n, cn);
            }

            Dictionary<int, int> sbg = new ();
            foreach (var n in vn)
            {
                int g = uf.Find(n);
                if (!sbg.ContainsKey(g)) sbg[g] = 0;
                sbg[g]++;
            }

            foreach (var (_, s) in sbg.Where(x => x.Value >= 2))
            {
                ans += (s * (s - 1)) / 2;
            }
        }

        return ans;
    }
}

public class UnionFind
{
    private readonly int[] _parent;
    private readonly int[] _size;

    public UnionFind(int n)
    {
        this._parent = new int[n];
        this._size = new int[n];
        
        for (var i = 0; i < n; i++)
        {
            this._parent[i] = i;
            this._size[i] = 1;
        }
    }

    public int Find(int node)
    {
        while (node != this._parent[node])
        {
            this._parent[node] = this._parent[this._parent[node]];
            node = this._parent[node];
        }

        return node;
    }

    public void Union(int u, int v)
    {
        int parentU = this.Find(u), parentV = this.Find(v);
        if (parentU == parentV) return;

        if (this._size[parentU] < this._size[parentV])
        {
            this._parent[parentU] = parentV;
            this._size[parentV] += this._size[parentU];
        }
        else
        {
            this._parent[parentV] = parentU;
            this._size[parentU] += this._size[parentV];
        }
    }

}