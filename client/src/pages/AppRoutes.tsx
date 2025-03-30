import { Routes, Route, useLocation } from "react-router-dom";
import HomePage from "./HomePage";
import TestPage from "./TestPage";
import TutorialPage from "./TutorialPage";
import ScamDonationPage from "./ScamDonationPage";

import NavBar from "../components/Navbar";
import Footer from "../components/Footer";
import { Theme } from "@chakra-ui/react";
import ScamFacebookLoginPage from "./ScamFacebookLoginPage";

const AppRoutes: React.FC = () => {
  const location = useLocation();
  const scamPages = [
    "/dharmo.ee/donation",
    "/facebooke.com/security-alert/recover-account/context=Q7DVBAHu4mjUMkGURJPWF8C6M-6Q-pQtDrlfa",
  ];

  const isScamPage = scamPages.includes(location.pathname);

  return (
    <>
      <Theme appearance={isScamPage ? "light" : "dark"}>
        {!isScamPage && <NavBar />}
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/test" element={<TestPage />} />
          <Route path="/tutorial" element={<TutorialPage />} />
          <Route path="/dharmo.ee/donation" element={<ScamDonationPage />} />
          <Route
            path="/facebooke.com/security-alert/recover-account/context=Q7DVBAHu4mjUMkGURJPWF8C6M-6Q-pQtDrlfa"
            element={<ScamFacebookLoginPage />}
          />
        </Routes>
        {!isScamPage && <Footer />}
      </Theme>
    </>
  );
};

export default AppRoutes;
