import {
    FaPinterest,
    FaFacebookSquare,
    FaGithubSquare,
    FaInstagram,
    FaTwitterSquare,
    FaYoutube,
} from 'react-icons/fa';

const Footer = () => {
    return (
        <div className=' w-auto mx-auto py-10 px-10 grid lg:grid-cols-3 gap-10 bg-gray-700'>
            <div>
                <h1 className='w-full text-3xl font-bold text-[#00df9a]'>KAYAK MEETUP.</h1>
                <div className='flex justify-between md:w-[75%] my-6 text-[#00df9a]'>
                    <FaFacebookSquare size={30} />
                    <FaInstagram size={30} />
                    <FaTwitterSquare size={30} />
                    <FaYoutube size={30} />
                </div>
            </div>
            <div className='lg:col-span-2 flex justify-between mt-6'>
                <div>
                    <h6 className='font-bold text-2xl text-[#00df9a]'>Company</h6>
                    <ul className='text py-1 text-lg text-white'>
                        <li>Locations</li>
                        <li>Merch</li>
                        <li>Loyalty</li>
                        <li>Catering</li>
                    </ul>
                </div>
                <div>
                    <h6 className='font-bold text-2xl text-[#00df9a]'>Support</h6>
                    <ul className='text py-1 text-lg text-white'>
                        <li>Pricing</li>
                        <li>Nutrition</li>
                        <li>Allergy Information</li>
                        <li>FAQ</li>
                    </ul>
                </div>
                <div>
                    <h6 className='font-bold text-2xl text-[#00df9a]'>Company</h6>
                    <ul className='text py-1 text-lg text-white'>
                        <li>About</li>
                        <li>Blog</li>
                        <li>Jobs</li>
                        <li>Careers</li>
                    </ul>
                </div>
            </div>
        </div>
    );
};

export default Footer;