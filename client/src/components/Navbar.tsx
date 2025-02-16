import React, { useState } from "react";
import { Link, Box, Flex, Text, Stack, Tabs } from "@chakra-ui/react";
import { Link as RouterLink, useLocation } from "react-router-dom";

const NavBar: React.FC = () => {
  const [isOpen, setIsOpen] = useState<boolean>(false);

  const toggleHandler = () => setIsOpen(!isOpen);
  const location = useLocation();
 

  // Menu Items Array
const menuItems = [
    { label: "Esileht", to: "/" },
    { label: "Test", to: "/Test" },
    { label: "Õpetus", to: "/Tutorial" },
  ];
   const activeTab = menuItems.find(item => item.to === location.pathname)?.label || "Esileht";
  
  // SVG Icons 
  const CloseIcon = () => (
    <svg width="24" viewBox="0 0 18 18" xmlns="http://www.w3.org/2000/svg">
      <path fill="white" d="M9 7.586l4.95-4.95 1.414 1.414L10.414 9l4.95 4.95-1.414 1.414L9 10.414l-4.95 4.95-1.414-1.414L7.586 9l-4.95-4.95L4.05 2.636 9 7.586z" />
    </svg>
  );
  
  const MenuIcon = () => (
    <svg width="24" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg">
      <path fill="white" d="M0 3h20v2H0V3zm0 6h20v2H0V9zm0 6h20v2H0v-2z" />
    </svg>
  );
  
  

  return (
     <Box maxW="1000px" mx="auto" px={4} position="relative">
      
      <Box position="absolute" left={4} top="50%" transform="translateY(-50%)" fontSize="xl" fontWeight="bold">
        <Link href="/">Logo</Link>
      </Box>

      {/* Navbar container */}
      <Flex as="nav" align="center" justify="center" w="100%" p={4}>
        <Flex>
          <Box display={{ base: isOpen ? "block" : "none", md: "block" }}>
            <Stack align="center" direction={{ base: "column", md: "row" }} pt={[4, 2]}>
              <Tabs.Root variant="outline" fitted maxW="xl" borderBottom="none" defaultValue={activeTab}>
                <Tabs.List>
                  {menuItems.map(({ label, to }) => (
                    <RouterLink to={to} key={to}>
                      <Tabs.Trigger colorPalette="teal" value={label} >
                        <Text textStyle="xl">{label}</Text>
                      </Tabs.Trigger>
                    </RouterLink>
                  ))}
                </Tabs.List>
              </Tabs.Root>
            </Stack>
          </Box>
        </Flex>
      </Flex>

      {/* Mobile menu toggle on the right */}
      <Box position="absolute" right={4} top="50%" transform="translateY(-50%)" display={{ base: "block", md: "none" }} onClick={toggleHandler} cursor="pointer">
        {isOpen ? <CloseIcon /> : <MenuIcon />}
      </Box>
    </Box>
  );
};



export default NavBar;
