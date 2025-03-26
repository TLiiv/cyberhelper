import { useState, useEffect, useMemo } from "react";
import { Box, Button, VStack, Text, Heading, Card, Flex } from "@chakra-ui/react";
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

const EmailInbox: React.FC = () => {
  const [emails, setEmails] = useState<Email[]>([]);
  const [selectedEmail, setSelectedEmail] = useState<Email | null>(null);
  const [loading, setLoading] = useState(false);

  const [visibleCount, setVisibleCount] = useState(1);
  const [guessedEmails, setGuessedEmails] = useState<Set<number>>(new Set());




  useEffect(() => {
    setLoading(true);
    axios
      .get<Email[]>("https://localhost:7225/api/Emails/random")
      .then((response) => {
        setEmails(response.data);
      })
      .catch((error) => {
        console.error("Error fetching emails:", error);
      })
      .finally(() => {
        setLoading(false);
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

  // const visibilityHandler = () => {
  //   if (visibleCount < sortedEmails.length) {
  //     setVisibleCount((prev) => prev + 1);
  //     setSelectedEmail(sortedEmails[visibleCount]);
  //   }
  // }
  
  const visibilityHandler = () => {
    if (visibleCount < sortedEmails.length) {
      setVisibleCount((prev) => prev + 1);
    }
  };
  
     const handleGuess = (isPhishingGuess: boolean) => {
       if (!selectedEmail) return;
       setGuessedEmails((prev) => new Set(prev).add(selectedEmail.id));
    visibilityHandler();
  };
  const visibleEmails = sortedEmails.slice(0, visibleCount).reverse();
const isCurrentEmailGuessed = selectedEmail
    ? guessedEmails.has(selectedEmail.id)
    : false;


  return (
    <>
      <Flex flex="1">
        <VStack
          width="400px"
          align="stretch"
          bg="gray.100"
          height="90vh"
        >
          <VStack
            width="350"
            p={4}
            align="stretch"
            bg="gray.100"
            height="80vh"
            overflowY="auto"
          >
            {loading ? (
              <Text>Loading emails...</Text>
            ) : (
              visibleEmails.map((email) => (
                <Card.Root
                  key={email.id}
                  p={3}
                  borderRadius="2xl"
                  bg="gray.100"
                  shadow="lg"
                  cursor="pointer"
                  borderWidth="0px"
                  height="100px"
                  minHeight="100px"
                  maxHeight="100px"
                  width="320px" 
                  minWidth="320px" 
                  overflow="hidden"
                  onClick={() => {
                    setSelectedEmail(email);
                    markAsRead(email.id);
                  }}
                >
                  <Card.Title fontWeight={email.isRead ? "medium" : "bold"}>
                    {email.sender} {email.difficulty}
                  </Card.Title>
                  <Card.Description>{email.subject}</Card.Description>
                </Card.Root>
              ))
            )}
          </VStack>
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
                <Text>{selectedEmail.hiddenLink}</Text>
              </Box>
              <Box>

                <Flex mt={4} gap={4}>
              <Button
                colorPalette="teal"
                onClick={() => handleGuess(false)}
                disabled={isCurrentEmailGuessed}
              >
                Andmepüük
              </Button>
               <Button
                colorPalette="teal"
                onClick={() => handleGuess(false)}
                disabled={isCurrentEmailGuessed}
              >
                Legitiimne
              </Button>
            </Flex>
              </Box>
            </>
          ) : (
            <Text>Vali menüüst vaatamiseks email!</Text>
          )}
        </Box>
      </Flex>

    </>
  );

};

export default EmailInbox;

