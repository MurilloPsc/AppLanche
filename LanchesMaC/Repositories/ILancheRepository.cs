using LanchesMaC.Models;
using System.Collections.Generic;

namespace LanchesMaC.Repositories
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get; }
        IEnumerable<Lanche> LanchesPreferidos { get; }
        Lanche GetLancheById(int lancheId);
    }
}
