﻿namespace SDK.Core.Abstractions
{
    /// <summary>
    /// Definición para las entidades del patron de repositorio
    /// </summary>
    /// <typeparam name="TUserKey">Tipo que identificara el usuario</typeparam>
    public interface IEntityInteger<TUserKey> : IEntityBase<int, TUserKey>
    {

    }
}
