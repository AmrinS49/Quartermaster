import './Category.css';

type CategoryPair = [string, string];

interface Props {
    category: CategoryPair
}
export const CategoryItem = ({category}: Props) => {
    return (
        <button className="card category-card">
            {/*<img className="card-img-top" src=".../100px180/" alt="Card image cap"/>*/}
            <div className="card-body d-flex flex-column justify-content-between">
                <h3 className="card-title p-2 fs-1 category-title">{category[0]}</h3>
                <p className="card-text p-2">{category[1]}</p>
                {/*<a href="#" className="btn btn-primary">Go somewhere</a>*/}
            </div>
        </button>
    )
}