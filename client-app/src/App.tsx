import {MainLayout} from "./components/layout/MainLayout.tsx";

import './bootstrap-custom.css';
import './App.css';
import {CategoryList} from "./features/categories/components/CategoryList.tsx";

function App() {

    return (
        <>
            <MainLayout></MainLayout>
            <CategoryList></CategoryList>
        </>
    )
}

export default App
