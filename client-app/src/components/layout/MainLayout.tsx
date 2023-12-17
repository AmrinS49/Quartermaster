export const TopNavigation = () => {
    return (
        <nav className="py-2 px-3 navbar navbar-expand-lg navbar-dark bg-dark">
            <a className="navbar-brand navbar-brand-font" href="#">Quartermaster</a>
        </nav>
    );
}

export const MainLayout = () => {
    return (
        <>
            <TopNavigation/>
        </>
    )
}