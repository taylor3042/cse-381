﻿using AlgorithmLib;
using NUnit.Framework;

namespace AlgorithmLibTest;

[TestFixture]
public class DijkstraShortestPathTest
{
    [Test]
    public void Test1()
    {
        Graph g = new(5);
        g.SetLabel(0, "s");
        g.SetLabel(1, "t");
        g.SetLabel(2, "x");
        g.SetLabel(3, "y");
        g.SetLabel(4, "z");
        g.AddDirectedEdge(0, 1, 6);
        g.AddDirectedEdge(0, 3, 4);
        g.AddDirectedEdge(1, 2, 3);
        g.AddDirectedEdge(1, 3, 2);
        g.AddDirectedEdge(2, 4, 4);
        g.AddDirectedEdge(3, 1, 1);
        g.AddDirectedEdge(3, 2, 9);
        g.AddDirectedEdge(3, 4, 3);
        g.AddDirectedEdge(4, 2, 5);
        g.AddDirectedEdge(4, 0, 7);
        var (distance, pred) = DijkstraShortestPath.ShortestPath(g, 1);
        Assert.That(distance[0], Is.EqualTo(12));
        Assert.That(distance[1], Is.EqualTo(0));
        Assert.That(distance[2], Is.EqualTo(3));
        Assert.That(distance[3], Is.EqualTo(2));
        Assert.That(distance[4], Is.EqualTo(5));
        Assert.That(pred[0], Is.EqualTo(4));
        Assert.That(pred[1], Is.EqualTo(Graph.INF));
        Assert.That(pred[2], Is.EqualTo(1));
        Assert.That(pred[3], Is.EqualTo(1));
        Assert.That(pred[4], Is.EqualTo(3));
        Assert.Pass();

    }
}