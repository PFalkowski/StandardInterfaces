# StandardInterfaces

[![CI](https://github.com/PFalkowski/StandardInterfaces/actions/workflows/ci.yml/badge.svg)](https://github.com/PFalkowski/StandardInterfaces/actions/workflows/ci.yml)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=PFalkowski_StandardInterfaces&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=PFalkowski_StandardInterfaces)
[![NuGet](https://img.shields.io/nuget/v/StandardInterfaces.svg)](https://www.nuget.org/packages/StandardInterfaces)
[![Downloads](https://img.shields.io/nuget/dt/StandardInterfaces.svg)](https://www.nuget.org/packages/StandardInterfaces)
[![License: MIT](https://img.shields.io/github/license/PFalkowski/StandardInterfaces.svg)](https://github.com/PFalkowski/StandardInterfaces/blob/master/LICENSE)
[![Buy Me a Coffee](https://img.shields.io/badge/Buy%20Me%20a%20Coffee-FFDD00?logo=buymeacoffee&logoColor=black)](https://buymeacoffee.com/piotrfalkowski)

Everyday .NET design-pattern interfaces in a single `netstandard2.0` package — no dependencies, no opinions beyond the contracts.

## Install

```bash
dotnet add package StandardInterfaces
```

## Interfaces

### Repository pattern

```csharp
public interface IReadOnlyRepository<TEntity> where TEntity : class
{
    int Count();
    int Count(Expression<Func<TEntity, bool>> predicate);
    TEntity Get(Expression<Func<TEntity, bool>> predicate);
    IEnumerable<TEntity> GetAll();
    IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
}

public interface IRepository<TEntity> : IReadOnlyRepository<TEntity> where TEntity : class
{
    void Add(TEntity entity);
    void AddOrUpdate(TEntity entity);
    void AddRange(IEnumerable<TEntity> entities);
    void Remove(TEntity entity);
    void RemoveRange(IEnumerable<TEntity> entities);
    void RemoveAll(Expression<Func<TEntity, bool>> predicate);
    void RemoveAll();
    int SaveChanges();
}
```

### Unit of work

```csharp
public interface IUnitOfWork : IDisposable
{
    void Complete();
}
```

### Factories and builders

```csharp
public interface IFactory<out T>       { T GetInstance(); }

public interface IBuilder<out T>       { void Build(); T Entity { get; } }

public interface IFluentBuilder<out T> { IFluentBuilder<T> Build(); T Entity { get; } }
```

### Converters and formatters

```csharp
public interface IConverter<in TFrom, out TTo> { TTo Convert(TFrom input); }

public interface IFormatter<in T>              { string Format(T input); }
```

### Validation and equality

```csharp
public interface IValidatable          { bool IsValid(); }
public interface IValidatable<in T>    { bool IsValid(T validator); }

public interface IValueEquatable<in T> { bool ValueEquals(T other); }
```

## Usage example

```csharp
// Implement in your data layer:
public class OrderRepository : IRepository<Order>
{
    private readonly AppDbContext _db;
    public OrderRepository(AppDbContext db) => _db = db;

    public int Count() => _db.Orders.Count();
    public int Count(Expression<Func<Order, bool>> predicate) => _db.Orders.Count(predicate);
    public Order Get(Expression<Func<Order, bool>> predicate) => _db.Orders.First(predicate);
    public IEnumerable<Order> GetAll() => _db.Orders.ToList();
    public IEnumerable<Order> GetAll(Expression<Func<Order, bool>> predicate) => _db.Orders.Where(predicate).ToList();
    public void Add(Order entity) => _db.Orders.Add(entity);
    public void AddOrUpdate(Order entity) => _db.Orders.Update(entity);
    public void AddRange(IEnumerable<Order> entities) => _db.Orders.AddRange(entities);
    public void Remove(Order entity) => _db.Orders.Remove(entity);
    public void RemoveRange(IEnumerable<Order> entities) => _db.Orders.RemoveRange(entities);
    public void RemoveAll(Expression<Func<Order, bool>> predicate) => _db.Orders.RemoveRange(_db.Orders.Where(predicate));
    public void RemoveAll() => _db.Orders.RemoveRange(_db.Orders);
    public int SaveChanges() => _db.SaveChanges();
}
```

## License

MIT — see [LICENSE](https://github.com/PFalkowski/StandardInterfaces/blob/master/LICENSE). Contributions welcome.
