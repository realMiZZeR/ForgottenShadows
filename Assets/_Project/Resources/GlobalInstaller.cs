using Retroskuff.Core.Input;
using Zenject;

/// <summary>
/// Инициализация зависимостей, которые нужны всегда и везде.
/// </summary>
public class GlobalInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<InputBehaviour>()
            .FromNewComponentOnNewGameObject()
            .AsSingle();
    }
}