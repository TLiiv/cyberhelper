import { useState, useEffect, useMemo } from "react";
import { Box, Button, VStack, Text, Heading, Container, Card, Flex } from "@chakra-ui/react";
import axios from "axios";


interface Email {
  id: number;
  sender: string;
  subject: string;
  body: string;
  isPhishing: boolean;
  difficulty: number;
  hiddenLink: string
  
  isRead: boolean;
}



const EmailInbox = () => {
  const [emails, setEmails] = useState<Email[]>([]);
  
  const [selectedEmail, setSelectedEmail] = useState<Email | null>(null);

  
  useEffect(() => {
    axios
      .get<Email[]>("https://localhost:7225/api/Emails/random")
      .then((response) => {
        setEmails(response.data);
      })
      .catch((error) => {
        console.error("Error fetching emails:", error);
      });
  }, []);
  

   const markAsRead = (emailId: number) => {
    setEmails((prevEmails) =>
      prevEmails.map((email) =>
        email.id === emailId ? { ...email, isRead: true } : email
      )
    );
  };
  
  const sortedEmails = useMemo(
    () => emails.slice().sort((a, b) => a.difficulty - b.difficulty),
    [emails]
  );

  return (
    <>
    <Flex flex="1" >
            <VStack width="350px" p={4} align="stretch" bg="gray.100" >
              {sortedEmails.map((email) => (
                <Card.Root
                  height="100px"
                  _hover={{ bg: "gray.100" }}
                  key={email.id}
                  p={3}
                  borderRadius="2xl"
                  bg={"gray.100"}
                  shadow="lg"
                  cursor="pointer"
                  onClick={() => {setSelectedEmail(email);markAsRead(email.id); }}
                >
                  {/* DELETE DIFFICUTLY WHEN FINISHED */}
                  <Card.Title fontWeight={email.isRead ? "medium" : "bold"}>{email.sender}{ email.difficulty}</Card.Title>
                  <Card.Description>{email.subject}</Card.Description>
                </Card.Root>
              ))}
            </VStack>
            {/* Email Preview */}
            <Box flex="1" p={6} bg="gray.100">
              {selectedEmail ? (
                <>
                  <Heading size="md">{selectedEmail.subject}</Heading>
                  <Text fontSize="sm" color="gray.500">
                    From: {selectedEmail.sender}
                  </Text>
                  <Box mt={4} p={4} bg="gray.100" borderRadius="lg">
                <Text>{selectedEmail.body}</Text>
                 <Text>{selectedEmail.hiddenLink }</Text>
              </Box>
                </>
              ) : (
                <Text>Select an email to preview</Text>
              )}
            </Box>
      </Flex>
    </>
  );
};

export default EmailInbox;
