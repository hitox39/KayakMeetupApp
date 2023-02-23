import Sidebar from "./Sidebar";
import { ReactNode } from "react";
import Header from "./Header";
import Footer from "./Footer";


export default function Layout(props: { component: ReactNode }) {
    return (
        <div>
            <Header />
            <div className="">
                { <Sidebar /> }
                <div className="w-full h-max">
                    {props.component}
                </div>
                <Footer />
            </div>
        </div>
    )

};

