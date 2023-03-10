import { ReactNode } from "react";
import Header from "./Header";
import Footer from "./Footer";
import FindEvents from "./Groups/FindEvent/FindEvents";
import AddCasualForm from "./Groups/AddEvent/AddCasualForm";
import AddFishingForm from "./Groups/AddEvent/AddFishingForm";
import FishingEvents from "./Groups/Events/FishingEvents";


export default function Layout(props: { component: ReactNode }) {
    return (
        <div>
            <Header />
            <div>
                {props.component}
            </div>
            <FindEvents />
            <FishingEvents />
            <AddCasualForm />
            <Footer />
        </div>
    )

};

