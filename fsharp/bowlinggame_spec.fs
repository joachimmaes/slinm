namespace BowlingGame

  open Xunit
  open BowlingGame

  type BowlingGameTests() =
    [<Fact>]
    member x.``a new game``() =
        Assert.Equal(0,score [])

    [<Fact>]
    member x.``rolling 0``() =
        Assert.Equal(0,score [0])

    [<Fact>]
    member x.``rolling 1``() =
        Assert.Equal(1,score [1])

    [<Fact>]
    member x.``rolling 2``() =
        Assert.Equal(2,score [2])

    [<Fact>]
    member x.``rolling 1-1``() =
        Assert.Equal(2,score [1;1])
