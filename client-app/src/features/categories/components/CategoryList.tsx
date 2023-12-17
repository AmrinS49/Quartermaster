import {CategoryItem} from "./CategoryItem.tsx";
import './Category.css';

type CategoryPair = [string, string];

const categories: CategoryPair[] = [
    ["Bearings", "Round things"],
    ["Bolts", "Long things"],
    ["Rivets", "Poppy things"],
    ["Motors", "Spinny things"],
    ["Control System", "Brainy things"],
    ["Sensors", "Smart things"]
    ];

export const CategoryList = () => {
    console.log(categories);

    return (
        <div>
            <h2 className={"p-2 text-center category-title"}>Categories</h2>
            <div className={"container-fluid category-card-list"}>
                {categories.map((category: CategoryPair) => (
                    <CategoryItem category={category} key={category[0]}/>
                ))}
            </div>
        </div>
    )
}