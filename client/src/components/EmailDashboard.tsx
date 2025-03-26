import { useState } from "react";
import { Box,Flex,VStack,Text,Button,Heading, Input, Card, IconButton, HStack } from "@chakra-ui/react";
import { LuClipboardPen, LuMail, LuMailCheck, LuTrash2 } from "react-icons/lu";
import EmailInbox from "./EmailInbox";




const EmailDashboard: React.FC = () => {


  const user ="User"

  return (
    <Flex height="90vh" width="100%" bg="gray.300" borderRadius="4xl">
      {/* Sidebar */}
      <Flex width="100vw" height="90vh" position="relative" borderRadius="4xl">
        {/* Sidebar Navigation */}
        <VStack 
          borderRadius="4xl"
          width="250px" 
          align="stretch" 
          height="90vh" 
          position="absolute" 
          left="0" 
          bg="gray.300" 
          zIndex="1"
         
        >  
          <Flex flexDirection="column" gap={2} pl={10} pt={6}> 
          <Heading pt={2} pb={4} size="2xl" color="teal.600" textAlign="center"> <Flex align="center" justify="center" gap={2}>
              <LuMail style={{ fontSize: "1.6em" }}/>
              <Text as="span" color="teal.600">CyberMail</Text>
            </Flex>
          </Heading>
          <Heading  pb={4} size="2xl" color="white" textAlign="center"> Hello <Text as="span" color="teal.600">{user}</Text></Heading>
          <Button   colorPalette="teal" variant="solid" size="xl" rounded="2xl">Uus Mail</Button>
          <IconButton   variant="ghost" size="lg" _hover={{ bg: "none" }}> <LuMail/><Text>Sisendkaust</Text></IconButton>
          <IconButton  disabled variant="ghost" size="lg" _hover={{ bg: "none" }}><LuMailCheck/> <Text>Saadetud</Text></IconButton>
          <IconButton  disabled variant="ghost" size="lg" _hover={{ bg: "none" }}><LuClipboardPen/> <Text>Mustand</Text></IconButton>
          <IconButton  disabled variant="ghost" size="lg" _hover={{ bg: "none" }}><LuTrash2 /><Text>Prügikast</Text></IconButton>
          </Flex>
        </VStack>

        {/* Main Content (Navbar + Emails) */}
        <Flex width="80%" marginLeft="auto" flexDirection="column" borderRadius="4xl" overflow="hidden">
          {/* Navbar */}
          <Flex bg="gray.100" p={4}  alignItems="center" borderTopRadius="4xl">
            <Input
                
                placeholder="Otsi meile..."
                width="25%"
                bg="white"
                color="black"
                borderRadius="xl"
                disabled
              />
          </Flex>         
          <EmailInbox />
        </Flex>
      </Flex>
      
    </Flex>
  );
};

export default EmailDashboard;

