import Sidebar from "./Sidebar";
import {ReactNode} from "react";
import "./Layout.css";

export default function Layout(props: { component: ReactNode}){
return(
    <div className="flex">
        <Sidebar />
        <div className="w-full h-max">
            {props.component}
        </div>
    </div>
)
    
};

