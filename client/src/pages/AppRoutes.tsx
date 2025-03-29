import { Routes, Route, useLocation } from "react-router-dom";
import HomePage from "./HomePage";
import TestPage from "./TestPage";
import TutorialPage from "./TutorialPage";
import ScamDonationPage from "./ScamDonationPage";

import NavBar from "../components/Navbar";
import Footer from "../components/Footer";
import { Theme } from "@chakra-ui/react";

const AppRoutes: React.FC = () => {
  const location = useLocation();
  const scamPage = location.pathname === "/dharmo/donation";

  return (
    <>
      <Theme appearance={scamPage ? "light" : "dark"}>
        {!scamPage && <NavBar />}
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/test" element={<TestPage />} />
          <Route path="/tutorial" element={<TutorialPage />} />
          <Route path="/dharmo/donation" element={<ScamDonationPage />} />
        </Routes>
        {!scamPage && <Footer />}
      </Theme>
    </>
  );
};

export default AppRoutes;
