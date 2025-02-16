import React, { useState } from "react";
import { Link, Box, Flex, Text, Button, Stack, Tabs } from "@chakra-ui/react";
import { Link as RouterLink } from "react-router-dom";

const NavBar: React.FC = () => {
  const [isOpen, setIsOpen] = useState<boolean>(false);

  const toggleHandler = () => setIsOpen(!isOpen);

  // Menu Items Array
const menuItems = [
    { label: "Esileht", to: "/" },
    { label: "Test", to: "/Test" },
    { label: "Õpetus", to: "/Tutorial" },
  ];
  
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
    <Flex
      as="nav"
      align="center"
      justify="space-between"
      wrap="wrap"
      w="100%"
      p={4}
      bg="primary.500"
      color="white"
    >
      <Box fontSize="xl" fontWeight="bold">
        <Link href="/">Logo</Link>
      </Box>

      {/* Toggle Menu Icon */}
      <Box display={{ base: "block", md: "none" }} onClick={toggleHandler} cursor="pointer">
        {isOpen ? <CloseIcon /> : <MenuIcon />}
      </Box>

      {/* Navigation Links */}
       {/* <Tabs.Root variant="enclosed" maxW="md" fitted defaultValue={"tab-1"}>
      <Tabs.List>
        <Tabs.Trigger value="tab-1">Tab 1</Tabs.Trigger>
        <Tabs.Trigger value="tab-2">Tab 2</Tabs.Trigger>
        <Tabs.Trigger value="tab-3">Tab 3</Tabs.Trigger>
      </Tabs.List>
    </Tabs.Root> */}
      <Box
        display={{ base: isOpen ? "block" : "none", md: "block" }}
        flexBasis={{ base: "100%", md: "auto" }}
      >
        <Stack
          align="center"
          direction={{ base: "column", md: "row" }}
          pt={[4, 2]}
        >
          {/* "line", "subtle", "enclosed", "outline", "plain"
          <Tabs.Root  fitted  maxW="xl">
            <Tabs.List>
           {menuItems.map(({ label, to }) => (
            <RouterLink to={to}>
            <Tabs.Trigger colorPalette={'teal'} key={to} value={label}>
              <Text>{label}</Text>
           </Tabs.Trigger>
             </RouterLink>
           ))}
              </Tabs.List>
             </Tabs.Root> */}
          {menuItems.map(({ label, to }) => (
            <RouterLink to={to}>
            <Link key={to}>
              <Text>{label}</Text>
           </Link>
            </RouterLink>
          ))}
        </Stack>
      </Box>
    </Flex>
  );
};



export default NavBar;
